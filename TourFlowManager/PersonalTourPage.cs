using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourAgent.PersonalTourPage;
using PersonalPage;

namespace TourAgent.PersonalTourPage.PersonalTourManagment
{


    public partial class PersonalTourPage : Form
    {
        public PersonalTourPage()
        {
            InitializeComponent();
        }


        private void PersonalTourPage_Load_1(object sender, EventArgs e)
        {

        }

        private void btnTourManagement_Click_1(object sender, EventArgs e)
        {
            PersonalTourPage personalTourPage = new PersonalTourPage();
            personalTourPage.Show();
            this.Hide();
        }
        
        private void btnMainPage_Click_1(object sender, EventArgs e)
        {
            PersonalMainPage personalMainPage = new PersonalMainPage();
            personalMainPage.Show();
            this.Hide();
        }
    }
}
