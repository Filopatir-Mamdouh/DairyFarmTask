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
    public partial class MilkSales : Form
    {
        public MilkSales()
        {
            InitializeComponent();
            FillEmpId();
            ShowData();
        }

        DatabaseConnection connection = new DatabaseConnection();

        private void label9_Click(object sender, EventArgs e)
        {

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

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Finance finance = new Finance();
            this.Hide();
            finance.Show();
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

        private void FillEmpId()
        {
            String Query = "Select EmpID From EmpeeTb";
            EmpID.ValueMember = "EmpID";
            EmpID.DataSource = connection.GetData(Query);
        }

        private void MilkSales_Load(object sender, EventArgs e)
        {

        }

        private void quantity_OnValueChanged(object sender, EventArgs e)
        {
            if (quantity.Text != "")
            {
                int total = Convert.ToInt32(quantity.Text) * Convert.ToInt32(price.Text);
                Total.Text = "" + total;
            }
        }

        private void ShowData()
        {
            string Query = "Select * From MilkSalesTb";
            SalesList.DataSource = connection.GetData(Query);
        }

        private void clear()
        {
            EmpID.SelectedIndex = -1;
            client.Text = "";
            phone.Text = "";
            price.Text = "";
            quantity.Text = "";
            Total.Text = "";
        }

        private void SaveTransaction()
        {
            String Query = "INSERT INTO IncTB values('" + date.Value.Date + "' , 'Sales' , " + Total.Text + " , " + EmpID.SelectedValue.ToString() + ")";
            connection.SetData(Query);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpID.SelectedIndex == -1 || client.Text == "" || phone.Text == "" || price.Text == "" || quantity.Text == "" || Total.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    String Query = "INSERT INTO MilkSalesTb values('" + date.Value.Date + "' , " + price.Text + " , '" + client.Text +"' , " + phone.Text + " , " + EmpID.SelectedValue.ToString() + " , " + quantity.Text + " , " + Total.Text + ")";
                    connection.SetData(Query);
                    SaveTransaction();
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
        private void SalesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpID.SelectedValue = SalesList.SelectedRows[0].Cells[5].Value.ToString();
            client.Text = SalesList.SelectedRows[0].Cells[3].Value.ToString();
            price.Text = SalesList.SelectedRows[0].Cells[2].Value.ToString();
            phone.Text = SalesList.SelectedRows[0].Cells[4].Value.ToString();
            quantity.Text = SalesList.SelectedRows[0].Cells[6].Value.ToString();
            Total.Text = SalesList.SelectedRows[0].Cells[7].Value.ToString();
            date.Value = (DateTime)SalesList.SelectedRows[0].Cells[1].Value;
            if (EmpID.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(SalesList.SelectedRows[0].Cells[0].Value.ToString());
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
                    String Query = "DELETE FROM MilkSalesTb WHERE Sid = " + key;
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
                    String Query = "UPDATE MilkSalesTb set Date ='" + date.Value.Date + "' , Uprice = " + price.Text + " , ClientName =  '" + client.Text + "' , ClientPhone = " + phone.Text + " , EmpID = " + EmpID.SelectedValue.ToString() + " , Quantity = " + quantity.Text + " , Amount = " + Total.Text + " WHERE Sid = " + key;
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
