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
    }
}
