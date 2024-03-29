﻿using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Cows cow = new Cows();
            this.Hide();
            cow.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Milk_Production milk = new Milk_Production();
            this.Hide();
            milk.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            CowHealth health=new CowHealth();
            this.Hide();
            health.Show();
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
            Finance finance = new Finance();
            this.Hide();
            finance.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        DatabaseConnection connection = new DatabaseConnection();
        private void finance()
        {
            string Query = "Select SUM(IncAmt) From IncTB";
            int inc = Convert.ToInt32(connection.GetData(Query).Rows[0][0].ToString());
            Income.Text += " " + inc;
            Query = "Select SUM(ExpAmount) From ExpTb";
            int exp = Convert.ToInt32(connection.GetData(Query).Rows[0][0].ToString());
            Expen.Text += " " + exp;
            int total =  inc - exp;
            Balance.Text += " " + total;
        }

        private void logistic()
        {
            string Query = "Select Count(Cowid) From CowTb";
            Cows.Text = connection.GetData(Query).Rows[0][0].ToString();
            Query = "Select SUM(TotalMilk) From Milktb";
            Milk.Text = connection.GetData(Query).Rows[0][0].ToString() + "Litres" ;
            Query = "Select Count(EmpID) From EmpeeTb";
            EmpName.Text = connection.GetData(Query).Rows[0][0].ToString();
        }

        private void Highestvalue()
        {
            string Query = "Select Max(Amount) From MilkSalesTb";
            int sale = Convert.ToInt32(connection.GetData(Query).Rows[0][0].ToString());
            HighestSale.Text += " " + sale;
            Query = "Select Max(Date) From MilkSalesTb WHERE Amount = " + sale;
            SaleDate.Text = connection.GetData(Query).Rows[0][0].ToString();
            Query = "Select Max(ExpAmount) From ExpTb";
            int amount = Convert.ToInt32(connection.GetData(Query).Rows[0][0].ToString());
            HightExp.Text += " " + amount;
            Query = "Select Max(ExpDate) From ExpTb WHERE ExpAmount = " + amount;
            ExpDate.Text = connection.GetData(Query).Rows[0][0].ToString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            finance();
            logistic();
            Highestvalue();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
