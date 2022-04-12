using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace W_02_4._7._2
{
    public partial class Form_InputTeam : Form
    {
        SqlConnection sqlcnn = null;
        string connectionstr = "Server=tcp:2022-clc04-demo-server.database.windows.net,1433;Initial Catalog=2022_CLC04_CSDL_Demo_db;Persist Security Info=False;User ID=MinhHoang;Password=Hoangminh20127048;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public Form_InputTeam()
        {
            InitializeComponent();
        }

        private void Form_InputTeam_Load(object sender, EventArgs e)
        {
            
            

        }
        private void comboBox_player1_DropDown(object sender, EventArgs e)
        {
            sqlcnn = new SqlConnection();
            sqlcnn.ConnectionString = connectionstr;
            sqlcnn.Open();

            string sqlquery = "Select Name, TeamID from Team";

            SqlDataAdapter adpt = new SqlDataAdapter(sqlquery, sqlcnn);
            DataSet data = new DataSet();
            adpt.Fill(data);

            if (data.Tables.Count > 0)
            {
                //Dua du lieu vao combo box 
                comboBox_player1.DataSource = data.Tables[0];
                comboBox_player1.DisplayMember = "Name";
                comboBox_player1.ValueMember = "TeamID";

            }

            sqlcnn.Close();
            comboBox_player1.SelectedIndex = -1;
        }

        private void comboBox_player2_DropDown(object sender, EventArgs e)
        {
            sqlcnn = new SqlConnection();
            sqlcnn.ConnectionString = connectionstr;
            sqlcnn.Open();

            string sqlquery = "Select Name, TeamID from Team";

            SqlDataAdapter adpt = new SqlDataAdapter(sqlquery, sqlcnn);
            DataSet data = new DataSet();
            adpt.Fill(data);

            if (data.Tables.Count > 0)
            {
                //Dua du lieu vao combo box 
                comboBox_player2.DataSource = data.Tables[0];
                comboBox_player2.DisplayMember = "Name";
                comboBox_player2.ValueMember = "TeamID";

            }

            sqlcnn.Close();
            comboBox_player2.SelectedIndex = -1;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_player1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_player1.SelectedIndex != null)
            {
                string selected = comboBox_player1.SelectedValue.ToString();

            }
        }

        private void comboBox_player2_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
