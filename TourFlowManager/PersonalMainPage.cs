using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourAgent.PersonalTourPage;
using System.Windows.Forms;
using TourAgent.PersonalTourPage.PersonalTourManagment;

namespace PersonalPage
{
    public partial class PersonalMainPage : Form
    {
        public PersonalMainPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            PersonalMainPage personalMainPage = new PersonalMainPage();
            personalMainPage.Show();
            this.Hide();
        }

        private void btnTourManagement_Click(object sender, EventArgs e)
        {
            PersonalTourPage personalTourPage = new PersonalTourPage();
            personalTourPage.Show();
            this.Hide();
        }

        private void PersonalMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
