using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourAgent.AdminPage.AdminTourManagment;
using TourAgent.AdminPage.AdminUserManagement;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;
using System.Linq.Expressions;
using System.Windows.Forms.VisualStyles;

namespace TourAgent.AdminPage.AdminSystemManagement
{
    public partial class AdminTourPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");

        public AdminTourPage()
        {
            InitializeComponent();
            LoadGuidesComboBox();
            UpdateDataGridView();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            AdminMainPage adminMainPage = new AdminMainPage();
            adminMainPage.Show();
            this.Close();

        }
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            AdminEditUserPage adminUserMain = new AdminEditUserPage();
            adminUserMain.Show();
            this.Hide();
        }
        private void btnTourManagement_Click(object sender, EventArgs e)
        {
            AdminTourTypePage adminTourType = new AdminTourTypePage();
            adminTourType.Show();
            this.Hide();
        }

        private void btnSystemManagement_Click(object sender, EventArgs e)
        {
            AdminSystemPage adminSystemPage = new AdminSystemPage();
            adminSystemPage.Show();
            this.Hide();
        }
        private void btnDeletedTourType_Click(object sender, EventArgs e)
        {
            AdminDeletedTour adminDeletedTour = new AdminDeletedTour();
            adminDeletedTour.Show();
            this.Hide();
        }
        private void btnEditTourPage_Click(object sender, EventArgs e)
        {
            AdminTourPage adminTourPage = new AdminTourPage();
            adminTourPage.Show();
            this.Hide();
        }
        private void btnEditTourTypePage_Click(object sender, EventArgs e)
        {
            AdminTourTypePage adminTourTypePage = new AdminTourTypePage();
            adminTourTypePage.Show();
            this.Hide();
        }


        private void AdminTourPage_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tourFlowManagerDBDataSet.tbl_DeletedUsers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_DeletedUsersTableAdapter.Fill(this.tourFlowManagerDBDataSet.tbl_DeletedUsers);

        }
        


        private void btnAddTour_Click(object sender, EventArgs e)
        {
            if (IsEmpty()) return;
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Tours (TourName, TourTypeID, StartPointCityID, DestinationCityID, GuideID, StartDate, EndDate, Price, MaxParticipants) VALUES (@TourName, @TourTypeID, @StartPointCityID, @DestinationCityID, @GuideID, @StartDate, @EndDate, @Price, @MaxParticipants)", conn))
                {
                    cmd.Parameters.AddWithValue("@TourName", txtTourName.Text);
                    cmd.Parameters.AddWithValue("@TourTypeID", int.Parse(txtTourTypeID.Text));
                    cmd.Parameters.AddWithValue("@StartPointCityID", txtStartID.Text.Trim());
                    cmd.Parameters.AddWithValue("@DestinationCityID", txtDestinationID.Text.Trim());
                    cmd.Parameters.AddWithValue("@GuideID", cbGuideID.SelectedValue); //selected value valuememberi ekler.
                    cmd.Parameters.AddWithValue("@StartDate", dtStartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dtEndDate.Value);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@MaxParticipants", int.Parse(txtMaxParticipants.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tur başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataGridView();
                }
            }
            catch (Exception err)
            {
                HandleConstraintErrors(err);
            }
            finally { conn.Close(); }
        }
        private void btnEditTour_Click(object sender, EventArgs e)
        {
            if (dataGridViewTours.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz turu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsEmpty()) { return; }

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE tbl_Tours SET TourName = @TourName, TourTypeID = @TourTypeID, StartPointCityID = @StartPointCityID, DestinationCityID = @DestinationCityID, GuideID = @GuideID, StartDate = @StartDate, EndDate = @EndDate, Price = @Price, MaxParticipants = @MaxParticipants WHERE TourID = @TourID", conn))
                {
                    cmd.Parameters.AddWithValue("@TourID", dataGridViewTours.SelectedRows[0].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@TourName", txtTourName.Text);
                    cmd.Parameters.AddWithValue("@TourTypeID", int.Parse(txtTourTypeID.Text));
                    cmd.Parameters.AddWithValue("@StartPointCityID", txtStartID.Text.ToString());
                    cmd.Parameters.AddWithValue("@DestinationCityID", txtDestinationID.Text.ToString());
                    cmd.Parameters.AddWithValue("@GuideID", cbGuideID.SelectedValue);
                    cmd.Parameters.AddWithValue("@StartDate", dtStartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dtEndDate.Value);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@MaxParticipants", int.Parse(txtMaxParticipants.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tur başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataGridView();
                }
            }
            catch (Exception err)
            {
                HandleConstraintErrors(err);
            }
            finally { conn.Close(); }
        }
        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            if (dataGridViewTours.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz turu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int tourID = Convert.ToInt32(dataGridViewTours.SelectedRows[0].Cells[0].Value);
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Tours WHERE TourID = @TourID", conn))
                {
                    cmd.Parameters.AddWithValue("@TourID", tourID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tur başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataGridView();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Tur silinirken bir hata oluştu: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }


        private void HandleConstraintErrors(Exception err)
        {
            if (err.Message.Contains("ck_MaxParticipants"))
            {
                MessageBox.Show("Katılımcı sayısı negatif olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (err.Message.Contains("ck_DateRange"))
            {
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden önce olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (err.Message.Contains("fk_TourType"))
            {
                MessageBox.Show("Geçersiz Tur Türü ID'si!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (err.Message.Contains("PlateNumber") || err.Message.Contains("PlateNumber"))
            {
                MessageBox.Show("Geçersiz Şehir ID'si!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Bir hata oluştu: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtTourName.Text) ||
                string.IsNullOrWhiteSpace(txtTourTypeID.Text) ||
                string.IsNullOrWhiteSpace(txtStartID.Text) ||
                string.IsNullOrWhiteSpace(txtDestinationID.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtMaxParticipants.Text) ||
                cbGuideID.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private void UpdateDataGridView()
        {
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_Tours", conn))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewTours.DataSource = dataTable;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Veriler güncellenirken hata oluştu: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGuidesComboBox()
        {  //Combobox içine TourGuidelari tanımlama inner join ile usersdan firstname ve lastname ve UserID alıyorum
           //ve inner join ile where Rolename ="TourGuide" olup olmadıgına bakıyorum
           //ardından dataTable verileri yukleyip valuemember ve displaymember ile gorunen ve arkada calısan verılerı ayarlıyorum comboboxda.
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetTourGuideNames", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cbGuideID.Items.Clear(); // ComboBox'u temizle
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // ComboBox'a verileri ekle
                        cbGuideID.DataSource = dataTable;
                        cbGuideID.ValueMember = "UserID"; // ComboBox'tan seçildiğinde ID'yi döner
                        cbGuideID.DisplayMember = "FullNameWithID"; // ID ve isim birleşimi Comboboxda goruntulenir.
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridViewTours_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTours.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewTours.SelectedRows[0];
                txtTourName.Text = selectedRow.Cells[1].Value.ToString(); // TourName
                txtStartID.Text = selectedRow.Cells[2].Value.ToString(); // StartPointCityID
                txtDestinationID.Text = selectedRow.Cells[3].Value.ToString(); // DestinationCityID
                txtTourTypeID.Text = selectedRow.Cells[4].Value.ToString(); // TourTypeID
                cbGuideID.Text = selectedRow.Cells[5].Value.ToString(); // GuideID
                dtStartDate.Value = Convert.ToDateTime(selectedRow.Cells[6].Value.ToString()); // StartDate
                dtEndDate.Value = Convert.ToDateTime(selectedRow.Cells[7].Value.ToString()); // EndDate
                txtPrice.Text = selectedRow.Cells[8].Value.ToString(); // Price
                txtMaxParticipants.Text = selectedRow.Cells[9].Value.ToString(); // MaxParticipants
            }
        }
    }
}