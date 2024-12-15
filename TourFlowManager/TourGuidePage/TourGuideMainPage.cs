using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourAgent.TourGuidePage.TourGuideTourPage;
using TourAgent.TourGuidePage.TourGuideMainPage;
using TourAgent.TourGuidePage;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;



namespace TourAgent.TourGuidePage.TourGuideMainPage
{
    public partial class TourGuideMainPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");

        public TourGuideMainPage()
        {
            InitializeComponent();
        }
        private void btnMainPage_Click(object sender, EventArgs e)
        {
            TourGuideMainPage tourGuideMainPage = new TourGuideMainPage();
            tourGuideMainPage.Show();
            this.Close();

        }
        
        private void btnTourManagement_Click(object sender, EventArgs e)
        {
            TourGuideTourPage tourGuideTourPage = new TourGuideTourPage(); 
            tourGuideTourPage.Show(); 
            this.Hide();
        }


        private void TourGuideMainPage_Load(object sender, EventArgs e)
        {
            this.tbl_ToursTableAdapter.Fill(this.tourFlowManagerDBDataSet.tbl_Tours);

        }

        private void TourGuideMainPage_Load_1(object sender, EventArgs e)
        {

        }
    }
}