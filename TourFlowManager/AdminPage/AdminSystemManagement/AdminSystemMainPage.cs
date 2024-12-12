using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourAgent.AdminPage.AdminSystemManagement;
using TourAgent.AdminPage.AdminUserManagement;
using TourAgent.AdminPage;
using TourAgent.AdminPage.AdminTourManagment;

namespace TourAgent.AdminPage.AdminSystemManagement
{
    public partial class AdminSystemMainPage : Form
    {
        public AdminSystemMainPage()
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
            AdminTourMainPage adminTourMain = new AdminTourMainPage();
            adminTourMain.Show();
            this.Hide();
        }

        private void btnSystemManagement_Click(object sender, EventArgs e)
        {
            AdminSystemMainPage adminSystemMain = new AdminSystemMainPage();
            adminSystemMain.Show();
            this.Hide();
        }
    }
}
