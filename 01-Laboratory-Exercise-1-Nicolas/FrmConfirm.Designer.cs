namespace _01_Laboratory_Exercise_1_Nicolas
{
    partial class FrmConfirm
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
            this.lblStudentNoVal = new System.Windows.Forms.Label();
            this.lblProgramVal = new System.Windows.Forms.Label();
            this.lblLastNameVal = new System.Windows.Forms.Label();
            this.lblFirstNameVal = new System.Windows.Forms.Label();
            this.lblMiddleNameVal = new System.Windows.Forms.Label();
            this.lblAgeVal = new System.Windows.Forms.Label();
            this.lblContactNoVal = new System.Windows.Forms.Label();
            this.lblAddressVal = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentNoVal
            // 
            this.lblStudentNoVal.AutoSize = true;
            this.lblStudentNoVal.Location = new System.Drawing.Point(113, 40);
            this.lblStudentNoVal.Name = "lblStudentNoVal";
            this.lblStudentNoVal.Size = new System.Drawing.Size(73, 16);
            this.lblStudentNoVal.TabIndex = 0;
            this.lblStudentNoVal.Text = "Student No";
            // 
            // lblProgramVal
            // 
            this.lblProgramVal.AutoSize = true;
            this.lblProgramVal.Location = new System.Drawing.Point(126, 75);
            this.lblProgramVal.Name = "lblProgramVal";
            this.lblProgramVal.Size = new System.Drawing.Size(59, 16);
            this.lblProgramVal.TabIndex = 1;
            this.lblProgramVal.Text = "Program";
            // 
            // lblLastNameVal
            // 
            this.lblLastNameVal.AutoSize = true;
            this.lblLastNameVal.Location = new System.Drawing.Point(113, 105);
            this.lblLastNameVal.Name = "lblLastNameVal";
            this.lblLastNameVal.Size = new System.Drawing.Size(72, 16);
            this.lblLastNameVal.TabIndex = 2;
            this.lblLastNameVal.Text = "Last Name";
            // 
            // lblFirstNameVal
            // 
            this.lblFirstNameVal.AutoSize = true;
            this.lblFirstNameVal.Location = new System.Drawing.Point(114, 141);
            this.lblFirstNameVal.Name = "lblFirstNameVal";
            this.lblFirstNameVal.Size = new System.Drawing.Size(72, 16);
            this.lblFirstNameVal.TabIndex = 3;
            this.lblFirstNameVal.Text = "First Name";
            // 
            // lblMiddleNameVal
            // 
            this.lblMiddleNameVal.AutoSize = true;
            this.lblMiddleNameVal.Location = new System.Drawing.Point(114, 180);
            this.lblMiddleNameVal.Name = "lblMiddleNameVal";
            this.lblMiddleNameVal.Size = new System.Drawing.Size(88, 16);
            this.lblMiddleNameVal.TabIndex = 4;
            this.lblMiddleNameVal.Text = "Middle Name";
            // 
            // lblAgeVal
            // 
            this.lblAgeVal.AutoSize = true;
            this.lblAgeVal.Location = new System.Drawing.Point(126, 213);
            this.lblAgeVal.Name = "lblAgeVal";
            this.lblAgeVal.Size = new System.Drawing.Size(32, 16);
            this.lblAgeVal.TabIndex = 5;
            this.lblAgeVal.Text = "Age";
            // 
            // lblContactNoVal
            // 
            this.lblContactNoVal.AutoSize = true;
            this.lblContactNoVal.Location = new System.Drawing.Point(112, 238);
            this.lblContactNoVal.Name = "lblContactNoVal";
            this.lblContactNoVal.Size = new System.Drawing.Size(73, 16);
            this.lblContactNoVal.TabIndex = 6;
            this.lblContactNoVal.Text = "Contact No";
            // 
            // lblAddressVal
            // 
            this.lblAddressVal.AutoSize = true;
            this.lblAddressVal.Location = new System.Drawing.Point(113, 267);
            this.lblAddressVal.Name = "lblAddressVal";
            this.lblAddressVal.Size = new System.Drawing.Size(58, 16);
            this.lblAddressVal.TabIndex = 7;
            this.lblAddressVal.Text = "Address";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(297, 366);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 42);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAddressVal);
            this.Controls.Add(this.lblContactNoVal);
            this.Controls.Add(this.lblAgeVal);
            this.Controls.Add(this.lblMiddleNameVal);
            this.Controls.Add(this.lblFirstNameVal);
            this.Controls.Add(this.lblLastNameVal);
            this.Controls.Add(this.lblProgramVal);
            this.Controls.Add(this.lblStudentNoVal);
            this.Name = "FrmConfirm";
            this.Text = "FrmConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentNoVal;
        private System.Windows.Forms.Label lblProgramVal;
        private System.Windows.Forms.Label lblLastNameVal;
        private System.Windows.Forms.Label lblFirstNameVal;
        private System.Windows.Forms.Label lblMiddleNameVal;
        private System.Windows.Forms.Label lblAgeVal;
        private System.Windows.Forms.Label lblContactNoVal;
        private System.Windows.Forms.Label lblAddressVal;
        private System.Windows.Forms.Button btnSubmit;
    }
}