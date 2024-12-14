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
using TourAgent.AdminPage.AdminTourManagment;
using TourAgent.AdminPage.AdminUserManagement;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;
using TourAgent.AdminPage.AdminSystemManagement;
using TourAgent.AdminPage;

namespace TourAgent.TourGuidePage.TourGuideTourPage
{


    public partial class TourGuideTourPage : Form
    {
        SqlConnection conn = new SqlConnection("Data Source =.; Initial Catalog = TourFlowManagerDB; Integrated Security = True;");




        public TourGuideTourPage()
        {
            InitializeComponent();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            AdminMainPage adminMainPage = new AdminMainPage();
            adminMainPage.Show();
            this.Close();

        }
        private void btnTourManagement_Click(object sender, EventArgs e)
        {
            AdminTourTypePage adminTourType = new AdminTourTypePage();
            adminTourType.Show();
            this.Hide();
        }


        private void TourGuideTourPage_Load_1(object sender, EventArgs e)
        {
            LoadPersonnelList();
        }

        private void LoadPersonnelList()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT GuideID FROM tbl_Users", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                // ComboBox'ı doldur
                while (reader.Read())
                {
                    cbmGuide.Items.Add(new { Text = reader["GuideID"].ToString(), Value = reader["GuideID"].ToString() });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void cbmGuide_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGuideID = ((dynamic)cbmGuide.SelectedItem).Value;
            FilterDataByPersonnel(selectedGuideID);
        }

        private void FilterDataByPersonnel(string guideID)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM tbl_Users WHERE GuideID = @GuideID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@GuideID", guideID);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewUsers.DataSource = dt;  // DataGridView'a veri bind et
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri filtreleme hatası: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}