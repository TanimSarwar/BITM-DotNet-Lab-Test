using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTest1QS_A
{
    public partial class LunchBillCalculationApp : Form
    {
        public LunchBillCalculationApp()
        {
            InitializeComponent();
        }

        private void showTotalButton_Click(object sender, EventArgs e)
        {
            double ricePrice = Convert.ToInt32(ricePriceTextbox.Text);
            double fishPrice = Convert.ToInt32(fishPriceTextBox.Text);
            double meatPrice = Convert.ToInt32(meatPriceTextBox.Text);
            double price = ((ricePrice*20) + (fishPrice*80) + (meatPrice*100));
            totalBillTextBox.Text = price.ToString();
        }

        private void netBillButton_Click(object sender, EventArgs e)
        {
            double ricePrice = Convert.ToInt32(ricePriceTextbox.Text);
            double fishPrice = Convert.ToInt32(fishPriceTextBox.Text);
            double meatPrice = Convert.ToInt32(meatPriceTextBox.Text);
            double discount = Convert.ToInt32(discountTextBox.Text);
            double price = ((ricePrice * 20) + (fishPrice * 80) + (meatPrice * 100));
            double discountVar = (discount/100)*price;
            double priceWithDiscount = (price - discountVar);
            double vat = (priceWithDiscount*0.05);
            double netbill = priceWithDiscount + vat;
            MessageBox.Show(netbill.ToString());
        }
    }
}
