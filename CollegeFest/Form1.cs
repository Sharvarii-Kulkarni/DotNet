using System;
using System.Windows.Forms;

namespace CollegeFest
{
    public partial class Form1 : Form
    {
        // Delegate and event
        public delegate void FestHandler(int peopleCount);
        public event FestHandler CollegeFest;

        public Form1()
        {
            InitializeComponent();

            // Subscribe Decorator and Caterer to the event with labels
            CollegeFest += new Decorator(lblDecoration).OnCollegeFest;
            CollegeFest += new Caterer(lblCatering).OnCollegeFest;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfPeople = int.Parse(txtPeople.Text);
                CollegeFest?.Invoke(numberOfPeople); // Trigger event
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }

    // Caterer class (event subscriber)
    public class Caterer
    {
        private Label label;
        public Caterer(Label lbl)
        {
            label = lbl;
        }

        public void OnCollegeFest(int people)
        {
            int charges = people * 200;
            label.Text = $"Catering Charges: Rs. {charges}";
        }
    }

    // Decorator class (event subscriber)
    public class Decorator
    {
        private Label label;
        public Decorator(Label lbl)
        {
            label = lbl;
        }

        public void OnCollegeFest(int people)
        {
            int charges = 10000 + (people * 10);
            label.Text = $"Decoration Charges: Rs. {charges}";
        }
    }
}
