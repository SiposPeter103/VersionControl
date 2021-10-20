using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueAtRisk
{
    public partial class Form1 : Form
    {
        List<Tick> Ticks;
        PortfolioEntities context = new PortfolioEntities();
        public Form1()
        {
            InitializeComponent();
            Ticks = context.Ticks.ToList(); //renamed Tick to Ticks hogy mukodjon, valsz nem pipaltam be, hogy "singularize or pluralize..."
            dataGridView1.DataSource = Ticks;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
