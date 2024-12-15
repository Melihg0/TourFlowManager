using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourAgent.CustomerPage
{
    public partial class CustomerSelectTour : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");
        User user;
        public CustomerSelectTour()
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnEditTourPage_Click(object sender, EventArgs e)
        {

            CustomerEditTours customerEditTours = new CustomerEditTours();
            customerEditTours.Show();
            this.Hide();
        }

        private void CustomerSelectTour_Load(object sender, EventArgs e)
        {
            try
            {
                // tbl_Tours tablosundan verileri DataGridView'e yükleme
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM tbl_Tours", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.Show();
            this.Hide();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {//kayıt ol tuşu = datagridden tıklanan tura kullanıcının kayıt olması lazım

        }
    }

}