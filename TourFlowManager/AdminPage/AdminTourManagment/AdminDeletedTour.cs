﻿using System;
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
    }
}