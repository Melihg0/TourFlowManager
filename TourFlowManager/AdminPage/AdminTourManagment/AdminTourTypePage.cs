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
using TourAgent.AdminPage.AdminSystemManagement;

namespace TourAgent.AdminPage.AdminTourManagment
{
    public partial class AdminTourTypePage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");

        public AdminTourTypePage()
        {
            InitializeComponent();
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
        private void btnEditTourTypePage_Click(object sender, EventArgs e)
        {
            AdminTourTypePage adminTourTypePage = new AdminTourTypePage();
            adminTourTypePage.Show();
            this.Hide();
        }
        private void btnEditTourPage_Click(object sender, EventArgs e)
        {
            AdminTourPage adminTourPage = new AdminTourPage();
            adminTourPage.Show();
            this.Hide();
        }

        private void btnDeletedTourType_Click(object sender, EventArgs e)
        {
            AdminDeletedTour adminDeletedTour = new AdminDeletedTour();
            adminDeletedTour.Show();
            this.Hide();
        }

        private void AdminTourTypePage_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tourFlowManagerDBDataSet.tbl_TourTypes' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_TourTypesTableAdapter.Fill(this.tourFlowManagerDBDataSet.tbl_TourTypes);

        }

        private void btnAddTourType_Click(object sender, EventArgs e)
        {
            if (isEmpty()) { return; }
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO tbl_TourTypes (TypeName, Description) VALUES (@TypeName, @Description)", conn))
                {
                    cmd.Parameters.AddWithValue("@TypeName", txtTypeName.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tur tipi başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTourTypesDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ekleme sırasında bir hata oluştu: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }

        }

        private void btnEditTourType_Click(object sender, EventArgs e)
        {
            if (isEmpty()) { return; }
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE tbl_TourTypes SET TypeName = @TypeName, Description = @Description WHERE TourTypeID = @TourTypeID", conn))
                {
                    cmd.Parameters.AddWithValue("@TourTypeID", dataGridViewTourTypes.SelectedRows[0].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@TypeName", txtTypeName.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Tur tipi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTourTypesDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }
        private void btnDeleteTourType_Click(object sender, EventArgs e)
        {
            if (dataGridViewTourTypes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz tur tipini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM tbl_TourTypes WHERE TourTypeID = @TourTypeID", conn))
                {
                    cmd.Parameters.AddWithValue("@TourTypeID", dataGridViewTourTypes.SelectedRows[0].Cells[0].Value);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tur tipi başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateTourTypesDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Silme sırasında bir hata oluştu: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        private bool isEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtTypeName.Text))
            {
                MessageBox.Show("Lütfen Tür Adını giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private void UpdateTourTypesDataGridView()
        {
            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_TourTypes", conn))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewTourTypes.DataSource = dataTable;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Veriler Güncellenemedi: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewTourTypes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTourTypes.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewTourTypes.SelectedRows[0];
                txtTypeName.Text = selectedRow.Cells[1].Value.ToString(); // TypeName
                txtDescription.Text = selectedRow.Cells[2].Value.ToString(); // Description
            }
        }
    }
}