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
    public partial class Cows : Form
    {
        DatabaseConnection connection= new DatabaseConnection();
        public Cows()
        {
            InitializeComponent();
            ShowData();
        }

        private void ShowData()
        {
            string Query = "Select * From Cowtb";
            CowList.DataSource = connection.GetData(Query);

        }
        private void label6_Click(object sender, EventArgs e)
        {
            Milk_Production milk = new Milk_Production();
            this.Hide();
            milk.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            CowHealth health = new CowHealth();
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
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void clear()
        {
            CowName.Text = "";
            EarTag.Text = "";
            Color.Text = "";
            Breed.Text = "";
            Age.Text = "";
            Weight.Text = "";
            Pasture.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CowName.Text == "" || EarTag.Text == "" || Color.Text == "" || Breed.Text == "" || Age.Text == "" || Weight.Text == "" || Pasture.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    String Query = "INSERT INTO CowTb values('" + CowName.Text + "' , '" + EarTag.Text + "' , '" + Color.Text + "' , '" + Breed.Text + "' , " + Convert.ToInt32(Age.Text) +" , "+ Convert.ToInt32(Weight.Text)+", '" + Pasture.Text +"')";
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

        private void DoB_onValueChanged(object sender, EventArgs e)
        {
            if (DoB.Value > DateTime.Today.Date) {
                DoB.Value = DateTime.Today.Date; 
            }
            Age.Text = ""+ (DateTime.Today.Date - DoB.Value.Date).Days/365;
        }
    }
}
