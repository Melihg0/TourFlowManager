using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing.Text;
using System.Linq.Expressions;
using TourAgent.AdminPage;
using TourAgent.CustomerPage;
using TourAgent.TourGuidePage;


namespace TourAgent
{
    public partial class LoginPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");
        User user = null;
        bool isPasswordVisible = false;
        public LoginPage()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '•';
        }

        private void pbTogglePassword_Click(object sender, EventArgs e)
        {

            if (isPasswordVisible == true)
            {
                // Şifreyi gizle
                txtPassword.PasswordChar = '•';
                pbHidePassword.Image = ByteArrayToImage(Properties.Resources.eye);
                isPasswordVisible = false;
            }
            else
            {
                // Şifreyi göster
                txtPassword.PasswordChar = '\0';
                pbHidePassword.Image = ByteArrayToImage(Properties.Resources.eye_crossed);
                isPasswordVisible = true;
            }
        }

        private Image ByteArrayToImage(byte[] byteArray) //byteArray adında byte dizi parametresi alır.
        {
            using (MemoryStream ms = new MemoryStream(byteArray)) //using ile otomatik temizleme yapılır.
                                                                  //MemoryStream ram ile çalışan veri akışıdır.Doğrudan bellekte işlenir.    
                return Image.FromStream(ms); //fromStream ile ms Resme dönüştürülür.

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            user = VerifyUser(txtMail.Text, txtPassword.Text);
            if (user != null)
            {
                switch (user.RoleID)
                {
                    case 1:
                        // Admin sayfasına yönlendir
                        AdminMainPage adminPage = new AdminMainPage();
                        adminPage.Show();
                        this.Hide();
                        break;
                    case 2:
                        // TourGuide sayfasına yönlendir
                        TourGuideMainPage tourGuidePage = new TourGuideMainPage();
                        tourGuidePage.Show();
                        this.Hide();
                        break;
                    case 3:
                        // Standart kullanıcı sayfasına yönlendir
                        CustomerMainPage customerPage = new CustomerMainPage();
                        customerPage.Show();
                        this.Hide();
                        break;
                }
            }
        }
        private User VerifyUser(string mail, string password)
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("sp_ValidateUser", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Email", mail);
                command.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader result = command.ExecuteReader())
                {

                    if (!result.HasRows) //SqlDataReader boş ise false döner.
                    {
                        // Kullanıcı bulunamadı
                        MessageBox.Show("E-posta veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    if (result.Read()) //Read() fonksiyonu bir kere okuma gerçekleştirir eğer 1 satır varsa true döner.
                    {
                        user = new User
                        {
                            UserID = Convert.ToInt32(result["UserID"]),
                            FirstName = Convert.ToString(result["FirstName"]),
                            LastName = Convert.ToString(result["LastName"]),
                            Email = Convert.ToString(result["Email"]),
                            RoleID = Convert.ToInt32(result["RoleID"]),
                            PhoneNumber = Convert.ToString(result["PhoneNumber"]),
                            UserPassword = Convert.ToString(result["UserPassword"]),
                            BirthDate = Convert.ToDateTime(result["BirthDate"]),
                            CreatedDate = Convert.ToDateTime(result["CreatedAt"])
                        };
                    }             
                }

                return user;
            }
            catch (Exception err)
            {
                MessageBox.Show("Beklenmedik bir hata olustu: " + err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally { conn.Close(); }
        }

        private void btnYeniHesap_Click(object sender, EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            this.Hide();
           
        }
    } 
}        
    



