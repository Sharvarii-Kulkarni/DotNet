using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        TextBox display;
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
            InitializeCalculatorUI();
        }

        private void InitializeCalculatorUI()
        {
            this.Text = "Simple Calculator";
            this.Size = new Size(350, 500);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            display = new TextBox();
            display.Size = new Size(300, 40);
            display.Location = new Point(20, 20);
            display.Font = new Font("Segoe UI", 16);
            display.ReadOnly = true;
            display.TextAlign = HorizontalAlignment.Right;
            this.Controls.Add(display);

            string[] buttons = {
                "7", "8", "9", "/",
                "4", "5", "6", "*",
                "1", "2", "3", "-",
                "0", ".", "=", "+",
                "C", "%", "√", "^"
            };

            int x = 20, y = 80;
            int btnWidth = 60, btnHeight = 50;
            int count = 0;

            foreach (string text in buttons)
            {
                Button btn = new Button();
                btn.Text = text;
                btn.Size = new Size(btnWidth, btnHeight);
                btn.Location = new Point(x, y);
                btn.Font = new Font("Segoe UI", 12);
                btn.Click += Button_Click;
                this.Controls.Add(btn);

                count++;
                x += btnWidth + 10;
                if (count % 4 == 0)
                {
                    x = 20;
                    y += btnHeight + 10;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "C")
            {
                display.Text = "";
                result = 0;
                operation = "";
                isOperationPerformed = false;
                return;
            }

            if (btn.Text == "=")
            {
                try
                {
                    double secondNumber = double.Parse(display.Text);
                    switch (operation)
                    {
                        case "+": result += secondNumber; break;
                        case "-": result -= secondNumber; break;
                        case "*": result *= secondNumber; break;
                        case "/": result = secondNumber != 0 ? result / secondNumber : throw new DivideByZeroException(); break;
                        case "%": result %= secondNumber; break;
                        case "^": result = Math.Pow(result, secondNumber); break;
                    }
                    display.Text = result.ToString();
                    isOperationPerformed = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                return;
            }

            if (btn.Text == "+" || btn.Text == "-" || btn.Text == "*" || btn.Text == "/" || btn.Text == "%" || btn.Text == "^")
            {
                try
                {
                    result = double.Parse(display.Text);
                    operation = btn.Text;
                    isOperationPerformed = true;
                }
                catch
                {
                    MessageBox.Show("Please enter a number first.");
                }
                return;
            }

            if (btn.Text == "√")
            {
                try
                {
                    double value = double.Parse(display.Text);
                    display.Text = Math.Sqrt(value).ToString();
                }
                catch
                {
                    MessageBox.Show("Invalid input for square root.");
                }
                return;
            }

            if (isOperationPerformed)
            {
                display.Text = "";
                isOperationPerformed = false;
            }

            display.Text += btn.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
