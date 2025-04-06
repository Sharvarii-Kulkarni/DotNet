namespace CollegeFest
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCatering;
        private System.Windows.Forms.Label lblDecoration;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCatering = new System.Windows.Forms.Label();
            this.lblDecoration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number of Students:";
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(250, 30);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(150, 26);
            this.txtPeople.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(100, 80);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 35);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Start Fest";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCatering
            // 
            this.lblCatering.AutoSize = true;
            this.lblCatering.Location = new System.Drawing.Point(30, 140);
            this.lblCatering.Name = "lblCatering";
            this.lblCatering.Size = new System.Drawing.Size(165, 20);
            this.lblCatering.TabIndex = 3;
            this.lblCatering.Text = "Catering Charges: Rs.";
            // 
            // lblDecoration
            // 
            this.lblDecoration.AutoSize = true;
            this.lblDecoration.Location = new System.Drawing.Point(12, 180);
            this.lblDecoration.Name = "lblDecoration";
            this.lblDecoration.Size = new System.Drawing.Size(183, 20);
            this.lblDecoration.TabIndex = 4;
            this.lblDecoration.Text = "Decoration Charges: Rs.";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPeople);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCatering);
            this.Controls.Add(this.lblDecoration);
            this.Name = "Form1";
            this.Text = "College Fest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
