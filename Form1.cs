using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int DepoistAmount = int.Parse(txtAmount.Text);
            double InsteretAmount = int.Parse(cmbInsteret.SelectedItem.ToString());
            double years = int.Parse(cmbYears.SelectedItem.ToString());
            double Result = DepoistAmount + ((InsteretAmount * years) / 100);
            txtTotal.Text = Result.ToString();
        }
    }
}
