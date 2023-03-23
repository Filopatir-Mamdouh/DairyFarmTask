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
                    String Query = "INSERT INTO HealthTb values(" + Cowid.SelectedValue.ToString() + " , '" + CowName.Text + "' , '" + Date.Value.Date + "' , '" + Event.Text + "' , '" + Diagnosis.Text + "' , '" + Treatment.Text + "' , " + Cost.Text + " , '"+VetName.Text+"')";
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
        private void HealthList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cowid.SelectedValue = HealthList.SelectedRows[0].Cells[1].Value.ToString();
            CowName.Text = HealthList.SelectedRows[0].Cells[2].Value.ToString();
            Event.Text = HealthList.SelectedRows[0].Cells[4].Value.ToString();
            Diagnosis.Text = HealthList.SelectedRows[0].Cells[5].Value.ToString();
            Treatment.Text = HealthList.SelectedRows[0].Cells[6].Value.ToString();
            Cost.Text = HealthList.SelectedRows[0].Cells[7].Value.ToString();
            VetName.Text = HealthList.SelectedRows[0].Cells[8].Value.ToString();
            Date.Value = (DateTime)HealthList.SelectedRows[0].Cells[3].Value;
            if (CowName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(HealthList.SelectedRows[0].Cells[0].Value.ToString());
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
                    String Query = "DELETE FROM HealthTb WHERE RepId = " + key;
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
                    String Query = "UPDATE HealthTb set Cowid = " + Convert.ToInt32(Cowid.Text) + " , CowName = '" + CowName.Text + "' , RepDate = '" + Date.Value.Date + "' , Event = '" + Event.Text + "' , Diagnosis =  '" + Diagnosis.Text + "' , Treatment = '" + Treatment.Text + "' , Cost = " + Convert.ToInt32(Cost.Text) + " , VetName = '"+ VetName.Text +"' WHERE RepId = " + key;
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
