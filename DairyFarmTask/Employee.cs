using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace DairyFarmTask
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        DatabaseConnection connection = new DatabaseConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            if (Gender.SelectedIndex == -1 || Name.Text == "" || Phone.Text == "" || Address.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    String Query = "INSERT INTO EmpeeTb values('" + Name.Text + "' , '" + DoB.Value.Date + "' , '" + Gender.Text + "', '" + Phone.Text + " , '" + Address.Text + "')";
                    connection.SetData(Query);
                    MessageBox.Show("Saved Successfully!!!");
                    clear();
                    ShowData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
