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
    public partial class CowHealth : Form
    {
        public CowHealth()
        {
            InitializeComponent();
            FillCowId();
            ShowData();
        }

        DatabaseConnection connection = new DatabaseConnection();

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
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

        private void FillCowId()
        {
            String Query = "Select Cowid From CowTb";
            Cowid.ValueMember = "Cowid";
            Cowid.DataSource = connection.GetData(Query);
        }

        private void ShowData()
        {
            string Query = "Select * From HealthTb";
            HealthList.DataSource = connection.GetData(Query);

        }
        private void Cowid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
