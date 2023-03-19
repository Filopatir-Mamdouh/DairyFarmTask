using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyFarmTask
{
    public partial class Milk_Production : Form
    {
        DatabaseConnection connection = new DatabaseConnection();
        public Milk_Production()
        {
            InitializeComponent();
            ShowData();
            FillCowId();
        }

        private void ShowData()
        {
            string Query = "Select * From MilkTb";
            MilkList.DataSource = connection.GetData(Query);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Cows cows = new Cows();
            this.Hide();
            cows.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            CowHealth cowHealth = new CowHealth();
            this.Hide();
            cowHealth.Show();
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
        
        private void FillCowId()
        {
            String Query = "Select Cowid From CowTb";
            Cowid.ValueMember = "Cowid";
            Cowid.DataSource = connection.GetData(Query);
        }

        private void clear()
        {
            Cowid.SelectedIndex = -1;
            CowName.Text = "";  
            AmMilk.Text = ""; 
            NoonMilk.Text = ""; 
            PmMilk.Text = ""; 
            TotalMilk.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cowid.SelectedIndex == -1 || CowName.Text == "" || AmMilk.Text == "" || NoonMilk.Text == "" || PmMilk.Text == "" || TotalMilk.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    String Query = "INSERT INTO MilkTb values(" + Cowid.SelectedValue.ToString() + " , '" + CowName.Text + "' , " + AmMilk.Text + " , " + NoonMilk.Text + " , " + PmMilk.Text + " , " + TotalMilk.Text + ", '" + Date.Value.Date + "')";
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
