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
                    String Query = "INSERT INTO MilkTb values(" + Cowid.SelectedValue.ToString() + " , '" + CowName.Text + "' , " + AmMilk.Text + " , " + NoonMilk.Text + " , " + PmMilk.Text + " , " + TotalMilk.Text + " , '" + Date.Value.Date + "')";
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

        private void PmMilk_OnValueChanged(object sender, EventArgs e)
        {
            if (PmMilk.Text != "")
            {
                int total = Convert.ToInt32(AmMilk.Text) + Convert.ToInt32(NoonMilk.Text) + Convert.ToInt32(PmMilk.Text);
                TotalMilk.Text = "" + total;
            }
        }

        int key = 0;
        private void MilkList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cowid.SelectedValue = MilkList.SelectedRows[0].Cells[1].Value.ToString();
            CowName.Text = MilkList.SelectedRows[0].Cells[2].Value.ToString();
            AmMilk.Text = MilkList.SelectedRows[0].Cells[3].Value.ToString();
            NoonMilk.Text = MilkList.SelectedRows[0].Cells[4].Value.ToString();
            PmMilk.Text = MilkList.SelectedRows[0].Cells[5].Value.ToString();
            TotalMilk.Text = MilkList.SelectedRows[0].Cells[6].Value.ToString();
            Date.Value = (DateTime)MilkList.SelectedRows[0].Cells[7].Value;
            if (CowName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(MilkList.SelectedRows[0].Cells[0].Value.ToString());
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
                    String Query = "DELETE FROM MilkTb WHERE Mid = " + key;
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
    }
}
