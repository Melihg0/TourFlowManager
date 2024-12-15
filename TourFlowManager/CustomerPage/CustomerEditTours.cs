using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourAgent.CustomerPage;
using TourAgent.TourGuidePage.TourGuideTourPage;

namespace TourAgent.CustomerPage
{
    public partial class CustomerEditTours : Form
    {
        public CustomerEditTours()
        {
            InitializeComponent();
        }

        private void CustomerEditTours_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourFlowManagerDBDataSet.tbl_Tours' table. You can move, or remove it, as needed.
            this.tbl_ToursTableAdapter.Fill(this.tourFlowManagerDBDataSet.tbl_Tours);

        }

        private void btnEditTourPage_Click(object sender, EventArgs e)
        {
            CustomerEditTours customerEditTours = new CustomerEditTours();
            customerEditTours.Show();
            this.Hide();
        }

        private void btnSelectTour_Click(object sender, EventArgs e)
        {
            CustomerSelectTour customerSelectTour = new CustomerSelectTour();
            customerSelectTour.Show();
            this.Hide();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            CustomerMainPage customerMainPage = new CustomerMainPage();
            customerMainPage.Show();
            this.Hide();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.Show();
            this.Hide();
        }
    }
}
