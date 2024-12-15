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
        }

        private void CustomerMainPage_Load(object sender, EventArgs e)
        {

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

        private void btnSelectTour_Click(object sender, EventArgs e)
        {
            CustomerSelectTour customerSelectTour = new CustomerSelectTour();
            customerSelectTour.Show();
            this.Hide();
        }

        private void btnEditTourPage_Click(object sender, EventArgs e)
        {
            CustomerEditTours customerEditTours = new CustomerEditTours();
            customerEditTours.Show();
            this.Hide();
        }
    }
}
