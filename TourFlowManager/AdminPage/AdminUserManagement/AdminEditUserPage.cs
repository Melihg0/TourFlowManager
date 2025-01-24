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
using TourAgent.AdminPage;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;
using TourAgent.AdminPage.AdminSystemManagement;

namespace TourAgent.AdminPage.AdminUserManagement
{
    public partial class AdminEditUserPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");
        string TelNo;
        public AdminEditUserPage()
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
        private void btnEditUserPage_Click(object sender, EventArgs e)
        {
            AdminEditUserPage adminUserMain = new AdminEditUserPage();
            adminUserMain.Show();
            this.Hide();
        }
        private void btnSystemManagement_Click(object sender, EventArgs e)
        {
            {
                AdminSystemPage adminSystemPage = new AdminSystemPage();
                adminSystemPage.Show();
                this.Close();

            }
        }
            private void btnDeletedUserPage_Click(object sender, EventArgs e)
        {
            DeletedUsersPage deletedUserPage = new DeletedUsersPage();
            deletedUserPage.Show();
            this.Hide();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int selectedRoleId = int.Parse(cbRoleID.Text.ToString());
            TelNo = Regex.Replace(maskedtxtTelefon.Text, @"[^\d\+]", "").Trim(); // \d digit yani rakamları temsil eder.
            if (isEmpty() || NumberControl()) { return; }

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_RegisterUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                    cmd.Parameters.AddWithValue("@Email", txtMail.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", TelNo);
                    cmd.Parameters.AddWithValue("@UserPassword", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@RoleID", selectedRoleId);
                    cmd.Parameters.AddWithValue("@BirthDate", dtBirthDate.Value);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Hesap Olusturuldu!", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdataDataGridView();
                }
            }
            catch (Exception err)
            {
                if (err.Message.Contains("ck_Email"))
                {
                    // Hatalı E mail Girisi.
                    MessageBox.Show("Geçerli bir e-posta adresi giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (err.Message.Contains("UNIQUE KEY"))
                {
                    // Onceden Kaydedilmis E mail girisi
                    MessageBox.Show("Bu e-posta adresi zaten kayıtlı.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally { conn.Close(); }
        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kullanıcıyı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TelNo = Regex.Replace(maskedtxtTelefon.Text, @"[^\d\+]", "").Trim(); // \d digit yani rakamları temsil eder.
            int selectedRoleId = int.Parse(cbRoleID.Text.ToString());
            if (isEmpty() || NumberControl()) { return; }
           

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_UpdateUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", dataGridViewUsers.SelectedRows[0].Cells[0].Value);// DataGridView'deki 0.indeksdeki sütunun satırının indeksini ID'ye ata
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);                                  //SelectedRows[0] birden fazla satır seçilmiş ise ilk seçilen satırı almak için işe yarar.
                    cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                    cmd.Parameters.AddWithValue("@Email", txtMail.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", TelNo);
                    cmd.Parameters.AddWithValue("@UserPassword", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@RoleID", selectedRoleId);
                    cmd.Parameters.AddWithValue("@BirthDate", dtBirthDate.Value);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kullanıcı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdataDataGridView();
            }
            catch (Exception err)
            {
                if (err.Message.Contains("ck_Email"))
                {
                    // Hatalı E mail Girisi.
                    MessageBox.Show("Geçerli bir e-posta adresi giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (err.Message.Contains("UNIQUE KEY"))
                {
                    // Onceden Kaydedilmis E mail girisi
                    MessageBox.Show("Bu e-posta adresi zaten kayıtlı. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally { conn.Close(); }
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int selectedUserId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells[0].Value);
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_DeleteUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", selectedUserId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kullanıcı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdataDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Kullanıcı silinirken bir hata oluştu: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }  
        }

        private bool isEmpty()
        {
            if     //Kutular Bos ise hata doner.
            (string.IsNullOrWhiteSpace(txtName.Text) ||
              string.IsNullOrWhiteSpace(txtSurname.Text) ||
              string.IsNullOrWhiteSpace(txtMail.Text) ||
              string.IsNullOrWhiteSpace(maskedtxtTelefon.Text) ||
              string.IsNullOrWhiteSpace(txtPassword.Text) ||
              string.IsNullOrWhiteSpace(cbRoleID.Text) ||
              string.IsNullOrWhiteSpace(dtBirthDate.Text))

            {
                MessageBox.Show("Lütfen kutucukları boş bırakmayınız!", "Tekrar Deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private bool NumberControl()
        {
            if (TelNo.Length < 13)
            {
                MessageBox.Show("Lutfen telefon numarasının basına ulke kodu yazarak tam olarak doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void AdminEditUserPage_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tourFlowManagerDBDataSet.tbl_Users' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UsersTableAdapter.Fill(this.tourFlowManagerDBDataSet.tbl_Users);
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            //data grid view bir indeksi seçerse bu if çalışır.
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {  //0.indeksteki satırı selectedRow içine atadık 
                var selectedRow = dataGridViewUsers.SelectedRows[0];
                //burada cells sütun sayısı hangi sütunu seçtiğimi gösteriyor.
                txtMail.Text = selectedRow.Cells[1].Value.ToString(); // Email
                txtName.Text = selectedRow.Cells[2].Value.ToString(); // FirstName
                txtSurname.Text = selectedRow.Cells[3].Value.ToString(); // LastName
                maskedtxtTelefon.Text = selectedRow.Cells[4].Value.ToString(); // PhoneNumber
                cbRoleID.Text = selectedRow.Cells[6].Value.ToString(); // RoleID
                dtBirthDate.Value = Convert.ToDateTime(selectedRow.Cells[7].Value); // BirthDate
                txtPassword.Text = selectedRow.Cells[5].Value.ToString(); //password
            }
        }
        private void UpdataDataGridView()
        {
            try
            {
                // Veri adaptörü ve veri tablosunu oluştur
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_Users", conn))
                {
                    DataTable dataTable = new DataTable();

                    // Veri tablosunu doldur
                    adapter.Fill(dataTable);

                    // DataGridView'e veri tablosunu bağla
                    dataGridViewUsers.DataSource = dataTable;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Veriler Güncellenirken bir hata olustu.: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
