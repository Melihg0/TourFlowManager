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
    public partial class AdminDeletedTour : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");
       
        public AdminDeletedTour()
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

        private void btnDeletedTourType_Click(object sender, EventArgs e)
        {
            AdminDeletedTour adminDeletedTour = new AdminDeletedTour();
            adminDeletedTour.Show();
            this.Hide();
        }

        private void btnEditTourPage_Click(object sender, EventArgs e)
        {
            AdminTourPage adminTourPage = new AdminTourPage();
            adminTourPage.Show();
            this.Hide();
        }

        private void btnEditTourTypePage_Click(object sender, EventArgs e)
        {
            AdminTourTypePage adminTourTypePage = new AdminTourTypePage();
            adminTourTypePage.Show();
            this.Hide();
        }
        private void AdminDeletedTour_Load_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tourFlowManagerDBDataSet.tbl_DeletedTours' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_DeletedToursTableAdapter.Fill(this.tourFlowManagerDBDataSet.tbl_DeletedTours);

        }
    }
}