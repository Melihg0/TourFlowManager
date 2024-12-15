using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class CustomerInfo : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");
        
        User user;
        public CustomerInfo()
        {
            this.user = user;
            InitializeComponent();
        }


        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                txtboxAd.Text = user.FirstName;
                txtBoxSoyad.Text = user.LastName;
                txtBoxEmail.Text = user.Email;
                txtBoxPhoneNumber.Text = user.PhoneNumber;
                dateTimePicker1.Text = user.BirthDate.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void Sifre_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void DogumTarihi_Click(object sender, EventArgs e)
        {

        }

        private void Telefon_Click(object sender, EventArgs e)
        {

        }

        private void Soyad_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectTour_Click(object sender, EventArgs e)
        {
            CustomerSelectTour customerSelectTour = new CustomerSelectTour();
            customerSelectTour.Show();
            this.Hide();
        }

        private void btnEditTourPage_Click(object sender, EventArgs e)
        {

            CustomerEditTours customerEditTours = new CustomerEditTours();
            customerEditTours.Show();
            this.Hide();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.Show();
            this.Hide();
        }

        private void txtboxAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBilgilerimiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=localhost;Initial Catalog=TourTracer;Integrated Security=True";

                string query = @"
                    UPDATE tbl_Users
                    SET FirstName = @FirstName,
                        LastName = @LastName,
                        Email = @Email,
                        PhoneNumber = @PhoneNumber,
                        BirthDate = @BirthDate
                    WHERE UserID = @UserID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", txtboxAd.Text);
                        command.Parameters.AddWithValue("@LastName", txtBoxSoyad.Text);
                        command.Parameters.AddWithValue("@Email", txtBoxEmail.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", txtBoxPhoneNumber.Text);
                        command.Parameters.AddWithValue("@BirthDate", Convert.ToDateTime(dateTimePicker1.Text));
                        command.Parameters.AddWithValue("@Password", txtBoxPassword);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bilgileriniz başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Bilgiler güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            CustomerMainPage customerMainPage = new CustomerMainPage();
            customerMainPage.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
