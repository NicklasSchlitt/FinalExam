namespace FinalExam
{
    partial class JoesCRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoesCRM));
            this.Customersbtn = new System.Windows.Forms.Button();
            this.Partsbtn = new System.Windows.Forms.Button();
            this.Invoicesbtn = new System.Windows.Forms.Button();
            this.Vehiclesbtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RevenueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Customersbtn
            // 
            resources.ApplyResources(this.Customersbtn, "Customersbtn");
            this.Customersbtn.Name = "Customersbtn";
            this.Customersbtn.UseVisualStyleBackColor = true;
            this.Customersbtn.Click += new System.EventHandler(this.Customersbtn_Click);
            // 
            // Partsbtn
            // 
            resources.ApplyResources(this.Partsbtn, "Partsbtn");
            this.Partsbtn.Name = "Partsbtn";
            this.Partsbtn.UseVisualStyleBackColor = true;
            this.Partsbtn.Click += new System.EventHandler(this.Partsbtn_Click);
            // 
            // Invoicesbtn
            // 
            resources.ApplyResources(this.Invoicesbtn, "Invoicesbtn");
            this.Invoicesbtn.Name = "Invoicesbtn";
            this.Invoicesbtn.UseVisualStyleBackColor = true;
            this.Invoicesbtn.Click += new System.EventHandler(this.Invoicesbtn_Click);
            // 
            // Vehiclesbtn
            // 
            resources.ApplyResources(this.Vehiclesbtn, "Vehiclesbtn");
            this.Vehiclesbtn.Name = "Vehiclesbtn";
            this.Vehiclesbtn.UseVisualStyleBackColor = true;
            this.Vehiclesbtn.Click += new System.EventHandler(this.Vehiclesbtn_Click);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // RevenueLabel
            // 
            resources.ApplyResources(this.RevenueLabel, "RevenueLabel");
            this.RevenueLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RevenueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RevenueLabel.Name = "RevenueLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // JoesCRM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RevenueLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Vehiclesbtn);
            this.Controls.Add(this.Invoicesbtn);
            this.Controls.Add(this.Partsbtn);
            this.Controls.Add(this.Customersbtn);
            this.Name = "JoesCRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Customersbtn;
        private System.Windows.Forms.Button Partsbtn;
        private System.Windows.Forms.Button Invoicesbtn;
        private System.Windows.Forms.Button Vehiclesbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label RevenueLabel;
        private System.Windows.Forms.Label label1;
    }
}

