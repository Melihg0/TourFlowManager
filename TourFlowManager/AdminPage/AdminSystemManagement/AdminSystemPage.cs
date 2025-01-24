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
using DocumentFormat.OpenXml.Office2013.Excel;
using ClosedXML.Excel;

namespace TourAgent.AdminPage.AdminSystemManagement
{
    public partial class AdminSystemPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");
        private string connectionString = "Data Source=.;Initial Catalog=TourFlowManagerDB;Integrated Security=True;";
        public AdminSystemPage()
        {
            InitializeComponent();
            LoadTableNames();
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
                { InitialCatalog = "master" }.ConnectionString;
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
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (cbTable.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir tablo seçin!");
                return;
            }
            string selectedTable = cbTable.SelectedItem.ToString();
            LoadDataGridTable(selectedTable); //DatagridViewe Gonderdik seçilen tabloyu
            DataTable dt = (DataTable)dataGridViewExport.DataSource; //DataGriddeki veri Datatable dolduruluyor.
            ExportToExcel(dt);//excel fonksiyonuna gönderiliyor.

        }
        //DataGridViewde gosterme butonu
        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            if (cbTable.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir tablo seçin!");
                return;
            }
            string selectedTable = cbTable.SelectedItem.ToString();
            LoadDataGridTable(selectedTable);
        }

        //Comboboxa Tabloları Ekleme
        private void LoadTableNames()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cbTable.Items.Add(reader["TABLE_NAME"].ToString());
                        cbImport.Items.Add(reader["TABLE_NAME"].ToString()); // cbImport'a da ekle
                    }
                    reader.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Tablo isimleri yüklenirken bir hata oluştu:" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //DatagridViewe Secılen Tablonun verilerini Ekleme 
        private void LoadDataGridTable(string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewExport.DataSource = table; // DataGridView'i doldur
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Tablo isimleri yüklenirken bir hata oluştu:" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportToExcel(DataTable table)
        {
            try
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    workbook.Worksheets.Add(table, "ExportedData");
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Dosyası (*.xlsx)|*.xlsx",
                        FileName = "ExportedData.xlsx"
                    };
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Veriler başarıyla dışa aktarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Excel dosyasına yazılırken bir hata oluştu:" + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Dosyası (*.xlsx)|*.xlsx",
                Title = "Excel Dosyasını Seç"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImport.Text = openFileDialog.FileName;
                LoadExcelToDataGridView(openFileDialog.FileName);
            }
        }

        private void LoadExcelToDataGridView(string filePath)
        {
            try
            {
                using (XLWorkbook workbook = new XLWorkbook(filePath))
                {
                    IXLWorksheet worksheet = workbook.Worksheet(1);
                    DataTable dt = new DataTable();

                    // Sütunları ekle
                    bool firstRow = true;
                    foreach (IXLRow row in worksheet.Rows())
                    {
                        if (firstRow)
                        {
                            foreach (IXLCell cell in row.Cells())
                            {
                                dt.Columns.Add(cell.Value.ToString());
                            }
                            firstRow = false;
                        }
                        else
                        {
                            dt.Rows.Add();
                            int i = 0;
                            foreach (IXLCell cell in row.Cells())
                            {
                                dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                i++;
                            }
                        }
                    }
                    dataGridViewImport.DataSource = dt;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Excel dosyasını yüklerken bir hata oluştu: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (cbImport.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir tablo seçin!");
                return;
            }

            string selectedTable = cbImport.SelectedItem.ToString();
            DataTable dt = (DataTable)dataGridViewImport.DataSource;

            if (dt == null)
            {
                MessageBox.Show("Lütfen içeri aktarılacak bir dosya seçin!");
                return;
            }

            // UserId sütununu hariç tut
            if (dt.Columns.Contains("UserId"))
            {
                dt.Columns.Remove("UserId");
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                    {
                        bulkCopy.DestinationTableName = selectedTable;

                        foreach (DataColumn column in dt.Columns)
                        {
                            bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                        }

                        bulkCopy.WriteToServer(dt);
                    }
                }
                MessageBox.Show("Veriler başarıyla içeri aktarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Veriler içeri aktarılırken bir hata oluştu: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
