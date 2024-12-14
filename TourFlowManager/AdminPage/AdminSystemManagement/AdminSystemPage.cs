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

namespace TourAgent.AdminPage.AdminSystemManagement
{
    public partial class AdminSystemPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");

        public AdminSystemPage()
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

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // Kullanıcıdan dosya kaydetme yeri al
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Backup Files (*.bak)|*.bak",
                    Title = "Yedekleme Dosyasını Kaydet"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupFilePath = saveFileDialog.FileName;

                    using (SqlCommand command = new SqlCommand($"BACKUP DATABASE TourFlowManagerDB TO DISK = '{backupFilePath}'", conn))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Yedekleme işlemi başarılı!");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = new SqlConnectionStringBuilder(conn.ConnectionString)
                {InitialCatalog = "master"}.ConnectionString;
                conn.Open();

                // Kullanıcıdan geri yükleme dosyasını seçmesini iste
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Backup Files (*.bak)|*.bak",
                    Title = "Yedekleme Dosyasını Seç"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupFilePath = openFileDialog.FileName;

                    using (SqlCommand killConnections = new SqlCommand(
                    $@"ALTER DATABASE {"TourFlowManagerDB"} SET SINGLE_USER WITH ROLLBACK IMMEDIATE", conn))
                    {
                        killConnections.ExecuteNonQuery();
                    }

                    // Veritabanını geri yükleme komutu
                    using (SqlCommand command = new SqlCommand($"RESTORE DATABASE TourFlowManagerDB FROM DISK = '{backupFilePath}' WITH REPLACE", conn))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Veritabanını çoklu kullanıcı moduna geri al
                    using (SqlCommand multiUserMode = new SqlCommand(
                        $@"ALTER DATABASE {"TourFlowManagerDB"} SET MULTI_USER", conn))
                    {
                        multiUserMode.ExecuteNonQuery();
                    }
                    MessageBox.Show("Yedekten yükleme işlemi başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }
    }
}