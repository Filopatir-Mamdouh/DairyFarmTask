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
            if (Cowid.SelectedIndex != -1)
            {
                String Query = "Select CowName From CowTb WHERE Cowid = " + Cowid.SelectedValue.ToString();
                foreach (DataRow dr in connection.GetData(Query).Rows)
                {
                    CowName.Text = dr["CowName"].ToString();
                }
            }
        }

        private void clear()
        {
            Cowid.SelectedIndex = -1;
            CowName.Text = "";
            Event.Text = ""; 
            Diagnosis.Text = "";
            Treatment.Text = "";
            Cost.Text = ""; 
            VetName.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cowid.SelectedIndex == -1 || CowName.Text == "" || Event.Text == "" || Diagnosis.Text == "" || Treatment.Text == "" || Cost.Text == "" || VetName.Text== "")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    String Query = "INSERT INTO HealthTb values(" + Cowid.SelectedValue.ToString() + " , '" + CowName.Text + "' , '" + Date.Value.Date + "' , '" + Event.Text + "' , '" + Diagnosis.Text + "' , " + Treatment.Text + " , " + Cost.Text + " , '"+VetName.Text+")";
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
