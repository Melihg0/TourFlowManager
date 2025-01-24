using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourAgent.AdminPage;
using TourAgent.AdminPage.AdminSystemManagement;
using TourAgent.AdminPage.AdminTourManagment;
using TourAgent.AdminPage.AdminUserManagement;

namespace TourAgent.AdminPage
{
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            AdminMainPage adminMainPage = new AdminMainPage();
            adminMainPage.Show();
            this.Close();
        }
        private void btnTourManagement_Click(object sender, EventArgs e)
        {
            AdminTourTypePage adminTourType = new AdminTourTypePage();
            adminTourType.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            AdminEditUserPage adminEditUserPage = new AdminEditUserPage();
            adminEditUserPage.Show();
            this.Hide();
        }

        private void btnSystemManagement_Click(object sender, EventArgs e)
        {
            AdminSystemPage adminSystemPage = new AdminSystemPage();
            adminSystemPage.Show();
            this.Hide();
        }
    }
}
