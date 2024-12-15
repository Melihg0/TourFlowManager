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

namespace TourAgent.CustomerPage
{
    public partial class CustomerSelectTour : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");
        User user;
        public CustomerSelectTour()
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnEditTourPage_Click(object sender, EventArgs e)
        {

            CustomerEditTours customerEditTours = new CustomerEditTours();
            customerEditTours.Show();
            this.Hide();
        }

        private void CustomerSelectTour_Load(object sender, EventArgs e)
        {
            try
            {
                // tbl_Tours tablosundan verileri DataGridView'e yükleme
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_Tours", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.Show();
            this.Hide();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {//kayıt ol tuşu = datagridden tıklanan tura kullanıcının kayıt olması lazım
         // DataGridView'den seçilen satırın index'ini al
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

            // Seçilen satırdaki tur ID'sini al (burada, 0. kolonun tur ID'si olduğu varsayılıyor)
            int selectedTourId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);

            // Kullanıcıyı almak
            int userId = user.UserID;

            try
            {
                // Veritabanına bağlantıyı aç
                conn.Open();

                // Kullanıcıyı seçilen tura kaydedecek SQL sorgusunu hazırlayın
                string query = "INSERT INTO tbl_Reservations (UserID, TourID) VALUES (@UserID, @TourID)";            

                // SQL komutunu oluştur
                SqlCommand cmd = new SqlCommand(query, conn);

                // Parametreleri ekle
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@TourID", selectedTourId);

                // Komutu çalıştır
                cmd.ExecuteNonQuery();

                // Başarılı bir şekilde kaydedildi mesajı
                MessageBox.Show("Tur kaydınız başarıyla gerçekleşti.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya mesaj göster
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapat
                conn.Close();
            }
        }
    }

}