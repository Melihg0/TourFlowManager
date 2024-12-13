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


namespace TourAgent.TourGuidePage.TourGuideTourPage
{


    public partial class TourGuideTourPage : Form
    {
        public TourGuideTourPage()
        {
            InitializeComponent();
        }


        private void TourGuideTourPage_Load_1(object sender, EventArgs e)
        {

        }

        private void btnTourManagement_Click_1(object sender, EventArgs e)
        {
            TourGuideTourPage tourGuideTourPage  = new TourGuideTourPage();
            tourGuideTourPage.Show();
            this.Hide();
        }

        private void btnMainPage_Click_1(object sender, EventArgs e)
        {
            TourGuideTourPage tourGuideTourPage = new TourGuideTourPage();
            tourGuideTourPage.Show();
            this.Hide();
        }
    }
}
