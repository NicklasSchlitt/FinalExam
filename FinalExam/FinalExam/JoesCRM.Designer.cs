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
            this.Customersbtn.Location = new System.Drawing.Point(9, 113);
            this.Customersbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Customersbtn.Name = "Customersbtn";
            this.Customersbtn.Size = new System.Drawing.Size(145, 61);
            this.Customersbtn.TabIndex = 0;
            this.Customersbtn.Text = "Customers";
            this.Customersbtn.UseVisualStyleBackColor = true;
            this.Customersbtn.Click += new System.EventHandler(this.Customersbtn_Click);
            // 
            // Partsbtn
            // 
            this.Partsbtn.Location = new System.Drawing.Point(158, 113);
            this.Partsbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Partsbtn.Name = "Partsbtn";
            this.Partsbtn.Size = new System.Drawing.Size(145, 61);
            this.Partsbtn.TabIndex = 1;
            this.Partsbtn.Text = "Parts";
            this.Partsbtn.UseVisualStyleBackColor = true;
            this.Partsbtn.Click += new System.EventHandler(this.Partsbtn_Click);
            // 
            // Invoicesbtn
            // 
            this.Invoicesbtn.Location = new System.Drawing.Point(158, 177);
            this.Invoicesbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Invoicesbtn.Name = "Invoicesbtn";
            this.Invoicesbtn.Size = new System.Drawing.Size(145, 61);
            this.Invoicesbtn.TabIndex = 2;
            this.Invoicesbtn.Text = "Invoices";
            this.Invoicesbtn.UseVisualStyleBackColor = true;
            this.Invoicesbtn.Click += new System.EventHandler(this.Invoicesbtn_Click);
            // 
            // Vehiclesbtn
            // 
            this.Vehiclesbtn.Location = new System.Drawing.Point(9, 177);
            this.Vehiclesbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Vehiclesbtn.Name = "Vehiclesbtn";
            this.Vehiclesbtn.Size = new System.Drawing.Size(145, 61);
            this.Vehiclesbtn.TabIndex = 3;
            this.Vehiclesbtn.Text = "Vehicles";
            this.Vehiclesbtn.UseVisualStyleBackColor = true;
            this.Vehiclesbtn.Click += new System.EventHandler(this.Vehiclesbtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-2, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(314, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // RevenueLabel
            // 
            this.RevenueLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RevenueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RevenueLabel.Location = new System.Drawing.Point(9, 240);
            this.RevenueLabel.Name = "RevenueLabel";
            this.RevenueLabel.Size = new System.Drawing.Size(294, 34);
            this.RevenueLabel.TabIndex = 6;
            this.RevenueLabel.Text = "Monthly Revenue: +$536.32";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Joe\'s Automotive";
            // 
            // JoesCRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.BackgroundImage = global::FinalExam.Properties.Resources.texture_marble;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(310, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RevenueLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Vehiclesbtn);
            this.Controls.Add(this.Invoicesbtn);
            this.Controls.Add(this.Partsbtn);
            this.Controls.Add(this.Customersbtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "JoesCRM";
            this.Text = "Joe\'s Automotive";
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

