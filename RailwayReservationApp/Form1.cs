using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayReservationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTrain.Items.Add("Express 101");
            cmbTrain.Items.Add("Superfast 202");
            cmbTrain.Items.Add("Local 303");

            cmbSeatClass.Items.Add("First Class");
            cmbSeatClass.Items.Add("Second Class");
            cmbSeatClass.Items.Add("Sleeper Class");
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            string passengerName = txtName.Text;
            string trainName = cmbTrain.SelectedItem.ToString();
            string seatClass = cmbSeatClass.SelectedItem.ToString();
            int ticketCount;

            // Try to parse the number of tickets
            if (!int.TryParse(txtTickets.Text, out ticketCount))
            {
                MessageBox.Show("Please enter a valid number of tickets.");
                return;
            }

            // Calculate the ticket price (for simplicity, let's assume fixed prices)
            int pricePerTicket = seatClass == "First Class" ? 500 : seatClass == "Second Class" ? 300 : 150;
            int totalPrice = pricePerTicket * ticketCount;

            // Display the booking details
            listBoxDetails.Items.Add($"Passenger: {passengerName}");
            listBoxDetails.Items.Add($"Train: {trainName}");
            listBoxDetails.Items.Add($"Class: {seatClass}");
            listBoxDetails.Items.Add($"Tickets: {ticketCount}");
            listBoxDetails.Items.Add($"Total Price: Rs. {totalPrice}");
            listBoxDetails.Items.Add("---------------");

            // Clear inputs after booking
            txtName.Clear();
            cmbTrain.SelectedIndex = -1;
            cmbSeatClass.SelectedIndex = -1;
            txtTickets.Clear();
        }
    }
}
