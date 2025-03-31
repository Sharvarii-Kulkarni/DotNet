using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PerformCalculation(Func<double, double, double> operation)
        {
            double num1, num2, result;

            try
            {
                // Validate Input
                if (!double.TryParse(txtNumber1.Text, out num1) || !double.TryParse(txtNumber2.Text, out num2))
                {
                    throw new FormatException("Invalid input! Please enter numeric values.");
                }

                // Perform Calculation
                result = operation(num1, num2);

                lblResult.Text = $"Result: {result}";
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Cannot divide by zero!", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformCalculation((x, y) => x + y);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformCalculation((x, y) => x - y);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformCalculation((x, y) => x * y);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformCalculation((x, y) => y == 0 ? throw new DivideByZeroException() : x / y);
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            PerformCalculation((x, y) => y == 0 ? throw new DivideByZeroException() : x % y);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            lblResult.Text = "Result: 0";
            txtNumber1.Focus();
        }
    }
}
