using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace TourAgent
{
    public partial class RegisterPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");
        string TelNo;
        public RegisterPage()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '•';
            txtPasswordAgain.PasswordChar = '•';  //Password baslangıc degerleri
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            TelNo = Regex.Replace(maskedtxtTelefon.Text, @"[^\d\+]", "").Trim(); // \d digit yani rakamları temsil eder.
            if (isEmpty()||isPasswordmatch()||NumberControl()) { return; }  //boşsa sifreler eslesmiyorsa veya telefon Numarası duzgun gırılmemıs ıse hata doner. Kod sonlanır.
                                                                            
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
                    cmd.Parameters.AddWithValue("@RoleID", 3);
                    cmd.Parameters.AddWithValue("@BirthDate", dtBirthDate.Value);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Hesabınız Başarıyla Oluşturuldu!", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginPage loginPage = new LoginPage();
                loginPage.Show();   
                this.Close();

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
                    MessageBox.Show("Bu e-posta adresi zaten kayıtlı. Lütfen farklı bir e-posta adresi giriniz.", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show( err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally { conn.Close(); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbHidePassword1_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(txtPassword, pbHidePassword1);
        }

        private void pbHidePassword2_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(txtPasswordAgain, pbHidePassword2);
        }


        private void TogglePasswordVisibility(TextBox textBox, PictureBox pictureBox)
        {
            // Şifre görünürlüğünü kontrol et ve değiştir
            if (textBox.PasswordChar == '•')
            {
                textBox.PasswordChar = '\0'; // Şifreyi göster
                pictureBox.Image = ByteArrayToImage(Properties.Resources.eye_crossed);
            }
            else
            {
                textBox.PasswordChar = '•'; // Şifreyi gizle
                pictureBox.Image = ByteArrayToImage(Properties.Resources.eye);
            }
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
                return Image.FromStream(ms);
        }
        private bool isEmpty()
        {//Kutular Bos ise hata doner.
            if
            (string.IsNullOrWhiteSpace(txtName.Text) ||
              string.IsNullOrWhiteSpace(txtSurname.Text) ||
              string.IsNullOrWhiteSpace(txtMail.Text) ||
              string.IsNullOrWhiteSpace(TelNo) ||
              string.IsNullOrWhiteSpace(txtPassword.Text) ||
              string.IsNullOrWhiteSpace(txtPasswordAgain.Text))
            {
                MessageBox.Show("Lütfen kutucukları boş bırakmayınız!", "Tekrar Deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
          return false;
        }   

        private bool isPasswordmatch()
        { //sifreler eslesmiyorsa hata doner.
            if (txtPassword.Text != txtPasswordAgain.Text)
            {   MessageBox.Show("Şifreler birbirleriyle eşleşmiyor!", "Tekrar Deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPasswordAgain.Clear();
                txtPassword.Focus();
                return true;
            }
            return false;
        }
        

        private bool NumberControl()
        {
            if (TelNo.Length < 13)
            {
                MessageBox.Show("Lutfen telefon numaranızın basına ulke kodunuzu yazarak tam olarak doldurunuz.","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void lblGirisDon_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }
    }
}
     
