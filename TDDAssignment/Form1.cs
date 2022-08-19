using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDDAssignment
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            double p = double.Parse(principalBox.Text);
            double r = double.Parse(rateBox.Text);
            int t = int.Parse(timeBox.Text);
            amountBox.Text = (Int(p,r,t)).ToString();

            

        }

        public double Int(double principal, double rate, int time)
        {
            var amount = principal + (principal * rate * time / 100);
            return amount;
        }

        private void amountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savings_Load(object sender, EventArgs e)
        {

        }
    }
}
