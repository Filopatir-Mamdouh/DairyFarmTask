using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyFarmTask
{
    public partial class Breeding : Form
    {
        public Breeding()
        {
            InitializeComponent();
            FillCowId();
            ShowData();
        }

        DatabaseConnection connection = new DatabaseConnection();
        private void label14_Click(object sender, EventArgs e)
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
            string Query = "Select * From BreedTb";
            CowList.DataSource = connection.GetData(Query);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cowid.SelectedIndex != -1)
            {
                String Query = "Select * From CowTb WHERE Cowid = " + Cowid.SelectedValue.ToString();
                foreach (DataRow dr in connection.GetData(Query).Rows)
                {
                    CowName.Text = dr["CowName"].ToString();
                    Age.Text = dr["Age"].ToString();
                }
            }
        }

        private void clear()
        {
            Cowid.SelectedIndex = -1;
            CowName.Text = "";
            Age.Text = "";
            Remarks.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Cowid.SelectedIndex == -1 || CowName.Text == "" || Age.Text == "" || Remarks.Text == "" )
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    String Query = "INSERT INTO BreedTb values('" + HDate.Value.Date + "' , '" + BDate.Value.Date + "' , " + Cowid.SelectedValue.ToString() + " , '" + CowName.Text + "' , '" + PDate.Value.Date + "' , '" + EDate.Value.Date + "', '" + CDate.Value.Date + "' , " + Age.Text + " , '" + Remarks.Text + "')";
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
        private void CowList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cowid.SelectedValue = CowList.SelectedRows[0].Cells[3].Value.ToString();
            CowName.Text = CowList.SelectedRows[0].Cells[4].Value.ToString();
            Age.Text = CowList.SelectedRows[0].Cells[8].Value.ToString();
            Remarks.Text = CowList.SelectedRows[0].Cells[9].Value.ToString();
            HDate.Value = (DateTime)CowList.SelectedRows[0].Cells[1].Value;
            BDate.Value = (DateTime)CowList.SelectedRows[0].Cells[2].Value;
            PDate.Value = (DateTime)CowList.SelectedRows[0].Cells[5].Value;
            EDate.Value = (DateTime)CowList.SelectedRows[0].Cells[6].Value;
            CDate.Value = (DateTime)CowList.SelectedRows[0].Cells[7].Value;
            if (CowName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CowList.SelectedRows[0].Cells[0].Value.ToString());
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
                    String Query = "DELETE FROM BreedTb WHERE BrID = " + key;
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
                    String Query = "UPDATE BreedTb set HeatDate = '" + HDate.Value.Date + "' , BreedDate = '" + BDate.Value.Date + "' , CowID = " + Cowid.SelectedValue.ToString() + " , CowName = '" + CowName.Text + "' , PregDate = '" + PDate.Value.Date + "' , ExpDateCalve = '" + EDate.Value.Date + "' , DateCalved = '" + CDate.Value.Date + "' , CowAge = " + Age.Text + " , Remarks = '" + Remarks.Text + "' WHERE BrID = " + key;
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
