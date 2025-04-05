namespace HospitalOPDForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.labelDept = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.labelSymptoms = new System.Windows.Forms.Label();
            this.txtSymptoms = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(46, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(105, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Patient Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(169, 57);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(113, 99);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(38, 20);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age";
            this.labelAge.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(169, 99);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(54, 26);
            this.txtAge.TabIndex = 3;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(88, 145);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(63, 20);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(169, 145);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 28);
            this.cmbGender.TabIndex = 5;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Location = new System.Drawing.Point(57, 185);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(94, 20);
            this.labelDept.TabIndex = 6;
            this.labelDept.Text = "Department";
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(169, 185);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(121, 28);
            this.cmbDept.TabIndex = 7;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(58, 235);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(93, 20);
            this.labelContact.TabIndex = 8;
            this.labelContact.Text = "Contact No.\t";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(169, 232);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(159, 26);
            this.txtContact.TabIndex = 9;
            // 
            // labelSymptoms
            // 
            this.labelSymptoms.AutoSize = true;
            this.labelSymptoms.Location = new System.Drawing.Point(67, 279);
            this.labelSymptoms.Name = "labelSymptoms";
            this.labelSymptoms.Size = new System.Drawing.Size(84, 20);
            this.labelSymptoms.TabIndex = 10;
            this.labelSymptoms.Text = "Symptoms";
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Location = new System.Drawing.Point(169, 279);
            this.txtSymptoms.Multiline = true;
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(100, 26);
            this.txtSymptoms.TabIndex = 11;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(169, 337);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(89, 43);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 20;
            this.listBoxOutput.Location = new System.Drawing.Point(411, 57);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(269, 304);
            this.listBoxOutput.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtSymptoms);
            this.Controls.Add(this.labelSymptoms);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label labelSymptoms;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ListBox listBoxOutput;
    }
}

