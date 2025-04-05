using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalOPDForm
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");

            cmbDept.Items.Add("General Medicine");
            cmbDept.Items.Add("Pediatrics");
            cmbDept.Items.Add("Orthopedics");
            cmbDept.Items.Add("ENT");
            cmbDept.Items.Add("Dermatology");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string age = txtAge.Text.Trim();
            string gender = cmbGender.SelectedItem?.ToString();
            string dept = cmbDept.SelectedItem?.ToString();
            string contact = txtContact.Text.Trim();
            string symptoms = txtSymptoms.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(dept) ||
                string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(symptoms))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            listBoxOutput.Items.Add($"Patient: {name}");
            listBoxOutput.Items.Add($"Age: { age}");
            listBoxOutput.Items.Add($" Gender: {gender}");
            listBoxOutput.Items.Add($"Dept: {dept},");
            listBoxOutput.Items.Add($"Contact: {contact}");
            listBoxOutput.Items.Add($"Symptoms: {symptoms}");
            listBoxOutput.Items.Add("--------------------------------");

            // Optional: Clear inputs
            txtName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = -1;
            cmbDept.SelectedIndex = -1;
            txtContact.Clear();
            txtSymptoms.Clear();
        }
    }
}
