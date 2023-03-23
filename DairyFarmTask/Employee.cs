using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Xml.Linq;
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

        private void ShowData()
        {
            string Query = "Select * From EmpeeTb";
            EmpList.DataSource = connection.GetData(Query);
        }

        private void clear()
        {
            Gender.SelectedIndex = -1;
            Name.Text = "";
            Phone.Text = "";
            Address.Text = "";
            key = 0;
        }

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
                    String Query = "INSERT INTO EmpeeTb values('" + Name.Text + "' , '" + DoB.Value.Date + "' , '" + Gender.Text + "', " + Phone.Text + " , '" + Address.Text + "')";
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

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        int key = 0;
        private void EmpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Gender.SelectedValue = EmpList.SelectedRows[0].Cells[3].Value.ToString();
            Name.Text = EmpList.SelectedRows[0].Cells[1].Value.ToString();
            Phone.Text = EmpList.SelectedRows[0].Cells[4].Value.ToString();
            Address.Text = EmpList.SelectedRows[0].Cells[5].Value.ToString();
            DoB.Value = (DateTime)EmpList.SelectedRows[2].Cells[1].Value;
            if (Name.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmpList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Row");
            }
            else
            {
                try
                {
                    String Query = "DELETE FROM EmpeeTb WHERE EmpID = " + key;
                    connection.SetData(Query);
                    MessageBox.Show("Deleted Successfully!!!");
                    clear();
                    ShowData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select a Row");
            }
            else
            {
                try
                {
                    String Query = "UPDATE EmpeeTb set EmpName = '" + Name.Text + "' , EmpDob = '" + DoB.Value.Date + "' , Gender = '" + Gender.SelectedValue.ToString() + "' , phone = " + Phone.Text + " , Address = '" + Address.Text + "' WHERE EmpID = " + key;
                    connection.SetData(Query);
                    MessageBox.Show("Updated Successfully!!!");
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
