using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TShirtOrderCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // This event can be removed if not needed.
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int quantity;
            decimal pricePerShirt = 0;
            decimal totalPrice;
            const decimal GST_RATE = 0.09m;
            const decimal DISCOUNT_RATE = 0.10m;

            // Validate Quantity Input
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid number of T-shirts.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determine Selected Size Price
            if (rbSmall.Checked)
                pricePerShirt = 125;
            else if (rbMedium.Checked)
                pricePerShirt = 175;
            else if (rbLarge.Checked)
                pricePerShirt = 250;
            else
            {
                MessageBox.Show("Please select a T-shirt size.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate Base Price
            totalPrice = quantity * pricePerShirt;

            // Apply Discount if Promo Code is Correct
            if (txtPromoCode.Text.Trim().ToUpper() == "TRUEBLUE")
            {
                totalPrice -= totalPrice * DISCOUNT_RATE;
            }

            // Apply GST
            totalPrice += totalPrice * GST_RATE;

            // Display Final Price
            lblTotalPrice.Text = $"Total Price: Rs. {totalPrice:F2}";
        }
    }
}
