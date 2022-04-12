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
    public partial class roundForm : Form
    {
        SqlConnection sqlcnn = null;
        string connectionstr = "Server=tcp:2022-clc04-demo-server.database.windows.net,1433;Initial Catalog=2022_CLC04_CSDL_Demo_db;Persist Security Info=False;User ID=MinhHoang;Password=Hoangminh20127048;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public roundForm()
        {
            InitializeComponent();
        }

        private void roundForm_Load(object sender, EventArgs e)
        {
            playerName1.Text = Form_InputTeam.team1_name;
            playerName2 .Text = Form_InputTeam.team2_name;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            sqlcnn = new SqlConnection();
            sqlcnn.ConnectionString = connectionstr;
            sqlcnn .Open();

            string sqlquery = "Select indexRound from roundIndex";

            SqlDataAdapter adpt = new SqlDataAdapter(sqlquery, sqlcnn);
            DataSet data = new DataSet();
            adpt.Fill(data);

            if (data.Tables.Count > 0)
            {
                
                //Dua du lieu vao combo box 
                comboBox_Vong.DataSource = data.Tables[0];
                comboBox_Vong.DisplayMember = "indexRound";


            }

            sqlcnn.Close();
            comboBox_Vong.SelectedIndex = -1;
        }
        public static string vong = "";
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_Vong.SelectedIndex != null)
            {
                string selected_team_name = comboBox_Vong.GetItemText(comboBox_Vong.SelectedItem);
                vong = selected_team_name;
            }
        }
    }
}
