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
        DatabaseConnection con = new DatabaseConnection();
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
                    Employee emp = new Employee();
                    this.Hide();
                    emp.Show();
                }
                else{
                    string query = "SELECT count(*) From EmpyeeTb WHERE EmpName = '" + Name.Text + "' , EmpPass = '" + Pass.Text + "'";
                    if (Convert.ToInt32(con.GetData(query).Rows[0][0].ToString()) >= 1)
                    {
                        Cows cow = new Cows();
                        this.Hide();
                        cow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password");
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Name.Text = "";
            Pass.Text = "";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
