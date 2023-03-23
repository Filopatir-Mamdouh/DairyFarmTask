using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyFarmTask
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( Role.SelectedIndex == -1 || Name.Text == "" || Pass.Text == "")
            {
                MessageBox.Show("Fill the Missing Data");
            }
            else
            {
                if (Role.SelectedIndex == 0 &&  Name.Text =="Admin" &&  Pass.Text == "admin")
                {

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Name.Text = "";
            Pass.Text = "";
        }
    }
}
