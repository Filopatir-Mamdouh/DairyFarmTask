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

namespace DairyFarmTask
{
    public partial class Finance : Form
    {
        public Finance()
        {
            InitializeComponent();
            ShowDataExp();
            ShowDataInc();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            CowHealth cowHealth = new CowHealth();
            this.Hide();
            cowHealth.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Milk_Production milk = new Milk_Production();
            this.Hide();
            milk.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Breeding breeding = new Breeding();
            this.Hide();
            breeding.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            MilkSales sales = new MilkSales();
            this.Hide();
            sales.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Cows cows = new Cows();
            this.Hide();
            cows.Show();
        }
        DatabaseConnection connection = new DatabaseConnection();

        private void ShowDataExp()
        {
            string Query = "Select * From ExpTb";
            ExpenList.DataSource = connection.GetData(Query);
        }

        private void ShowDataInc()
        {
            string Query = "Select * From IncTB";
            IncList.DataSource = connection.GetData(Query);
        }

        private void clearexp()
        {
            purpose.SelectedIndex = -1;
            Amount.Text = "";
        }

        private void clearInc()
        {
            Type.SelectedIndex = -1;
            IAmount.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (purpose.SelectedIndex == -1 || Amount.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    String Query = "INSERT INTO ExpTb values('" + date.Value.Date + "' , '" + purpose.SelectedItem.ToString() + "' , " + Amount.Text + " , 1 )";
                    connection.SetData(Query);
                    MessageBox.Show("Saved Successfully!!!");
                    clearexp();
                    ShowDataExp();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Type.SelectedIndex == -1 || IAmount.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    String Query = "INSERT INTO IncTB values('" + IDate.Value.Date + "' , '" + Type.SelectedItem.ToString() + "' , " + IAmount.Text + " , 1 )";
                    connection.SetData(Query);
                    MessageBox.Show("Saved Successfully!!!");
                    clearInc();
                    ShowDataInc();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            string Query = "Select * From ExpTb WHERE ExpDate = '"+ bunifuDatepicker1.Value.Date+"'";
            ExpenList.DataSource = connection.GetData(Query);
        }

        private void bunifuDatepicker3_onValueChanged(object sender, EventArgs e)
        {
            string Query = "Select * From IncTB WHERE IncDate = '" + bunifuDatepicker3.Value.Date + "'";
            IncList.DataSource = connection.GetData(Query);
        }
    }
}
