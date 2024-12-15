using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourAgent.CustomerPage;
using System.Data.Sql;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data.Common;
using TourAgent;



namespace TourAgent.CustomerPage
{
    public partial class CustomerEditTours : Form

    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");

        public CustomerEditTours()
        {
            InitializeComponent();
        }

        private void CustomerEditTours_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourFlowManagerDBDataSet.tbl_Tours' table. You can move, or remove it, as needed.
            this.tbl_ReservationsTableAdapter.Fill(this.tourFlowManagerDBDataSet.tbl_Reservations);
            int userId = User.UserID;  // User'dan alınır

            // Kullanıcının kayıt olduğu turları yüklemek için veri çekme
            LoadUserTours(userId);

        }

        private void btnEditTourPage_Click(object sender, EventArgs e)
        {
            CustomerEditTours customerEditTours = new CustomerEditTours();
            customerEditTours.Show();
            this.Hide();
        }

        private void btnSelectTour_Click(object sender, EventArgs e)
        {
            CustomerSelectTour customerSelectTour = new CustomerSelectTour();
            customerSelectTour.Show();
            this.Hide();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            CustomerMainPage customerMainPage = new CustomerMainPage();
            customerMainPage.Show();
            this.Hide();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadUserTours(int UserId)
        {
            string query = @"
                SELECT t.TourID, t.TourName, t.StartDate, t.EndDate, t.Price
                FROM tbl_Tours t
                INNER JOIN tbl_Reservations r ON t.TourID = r.TourID
                INNER JOIN tbl_Users u ON r.UserID = u.UserID
                WHERE u.UserID = @UserID";  // Kullanıcı ID'sine göre filtreleme

            using (SqlConnection connection = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;"))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@UserID", UserId);
                DataTable dataTable = new DataTable();

                // Veriyi al
                dataAdapter.Fill(dataTable);

                // DataGridView'e bağla
                dataGridView1.DataSource = dataTable;
            }
        }

        private void btnTurdanÇik_Click(object sender, EventArgs e)
        {
            // Seçilen turdan çıkabilmek için, DataGridView'den seçilen turun ID'sini alıyoruz
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedTourId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TourID"].Value);  // Seçilen turun ID'si
                int userId = User.UserID;  // Giriş yapan kullanıcının ID'si

                // Kullanıcıyı bu turdan çıkarmak için SQL sorgusu
                string query = "DELETE FROM tbl_Reservations WHERE UserID = @UserID AND TourID = @TourID";

                using (SqlConnection connection = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;"))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.Parameters.AddWithValue("@TourID", selectedTourId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();  // Sorguyu çalıştır

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Turdan başarıyla çıkıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Turdan çıkıldıktan sonra, DataGridView'i güncellemek için tekrar veriyi yükleyelim
                            LoadUserTours(userId);
                        }
                        else
                        {
                            MessageBox.Show("Turdan çıkma işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen çıkmak istediğiniz bir tur seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }



}