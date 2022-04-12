using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_02_4._7._2
{
    public partial class Form_Begin : Form
    {
        public Form_Begin()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_InputTeam new_forminputteam = new Form_InputTeam();
            new_forminputteam.Closed += (s, args) => this.Show();
            new_forminputteam.ShowDialog();
        }
    }
}
