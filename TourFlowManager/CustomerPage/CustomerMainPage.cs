using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourAgent.CustomerPage
{
    public partial class CustomerMainPage : Form
    {
        public CustomerMainPage()
        {
            InitializeComponent();
            this.Shown += new EventHandler(CustomerMainPage_Shown);
        }

        private void CustomerMainPage_Shown(object sender, EventArgs e)
        {
            ShowWarningMessage();
        }

        private void ShowWarningMessage()
        {
            // Uyarı mesajı gösterme
            var result = MessageBox.Show("Çok Yakında", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                // LoginPage formuna yönlendirme
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Close();
            }
        }
    }
}
