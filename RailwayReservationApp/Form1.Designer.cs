namespace RailwayReservationApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelTrain = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.cmbSeatClass = new System.Windows.Forms.ComboBox();
            this.cmbTrain = new System.Windows.Forms.ComboBox();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.listBoxDetails = new System.Windows.Forms.ListBox();
            this.labelTickets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(117, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(129, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Passenger name";
            // 
            // labelTrain
            // 
            this.labelTrain.AutoSize = true;
            this.labelTrain.Location = new System.Drawing.Point(345, 134);
            this.labelTrain.Name = "labelTrain";
            this.labelTrain.Size = new System.Drawing.Size(90, 20);
            this.labelTrain.TabIndex = 1;
            this.labelTrain.Text = "Train Name";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(117, 134);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(86, 20);
            this.labelClass.TabIndex = 2;
            this.labelClass.Text = "Seat Class";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 26);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Passenger name";
            // 
            // txtTickets
            // 
            this.txtTickets.Location = new System.Drawing.Point(367, 79);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(129, 26);
            this.txtTickets.TabIndex = 4;
            // 
            // cmbSeatClass
            // 
            this.cmbSeatClass.FormattingEnabled = true;
            this.cmbSeatClass.Location = new System.Drawing.Point(121, 171);
            this.cmbSeatClass.Name = "cmbSeatClass";
            this.cmbSeatClass.Size = new System.Drawing.Size(142, 28);
            this.cmbSeatClass.TabIndex = 5;
            // 
            // cmbTrain
            // 
            this.cmbTrain.FormattingEnabled = true;
            this.cmbTrain.Location = new System.Drawing.Point(331, 171);
            this.cmbTrain.Name = "cmbTrain";
            this.cmbTrain.Size = new System.Drawing.Size(145, 28);
            this.cmbTrain.TabIndex = 6;
            this.cmbTrain.Text = "Train name";
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.Location = new System.Drawing.Point(233, 228);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(121, 56);
            this.btnBookTicket.TabIndex = 7;
            this.btnBookTicket.Text = "Book ticket";
            this.btnBookTicket.UseVisualStyleBackColor = true;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // listBoxDetails
            // 
            this.listBoxDetails.FormattingEnabled = true;
            this.listBoxDetails.ItemHeight = 20;
            this.listBoxDetails.Location = new System.Drawing.Point(172, 307);
            this.listBoxDetails.Name = "listBoxDetails";
            this.listBoxDetails.Size = new System.Drawing.Size(243, 84);
            this.listBoxDetails.TabIndex = 8;
            // 
            // labelTickets
            // 
            this.labelTickets.AutoSize = true;
            this.labelTickets.Location = new System.Drawing.Point(363, 41);
            this.labelTickets.Name = "labelTickets";
            this.labelTickets.Size = new System.Drawing.Size(133, 20);
            this.labelTickets.TabIndex = 9;
            this.labelTickets.Text = "Number of tickets";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTickets);
            this.Controls.Add(this.listBoxDetails);
            this.Controls.Add(this.btnBookTicket);
            this.Controls.Add(this.cmbTrain);
            this.Controls.Add(this.cmbSeatClass);
            this.Controls.Add(this.txtTickets);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelTrain);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTrain;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTickets;
        private System.Windows.Forms.ComboBox cmbSeatClass;
        private System.Windows.Forms.ComboBox cmbTrain;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.ListBox listBoxDetails;
        private System.Windows.Forms.Label labelTickets;
    }
}

