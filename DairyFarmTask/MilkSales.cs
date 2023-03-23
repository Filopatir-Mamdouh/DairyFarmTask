﻿using System;
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
                    String Query = "INSERT INTO BreedTb values('" + date.Value.Date + "' , " + price.Text + " , '" + client.Text +"' , " + phone.Text + " , " + EmpID.SelectedValue.ToString() + " , " + quantity.Text + " , " + Total.Text + ")";
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
    }
}
