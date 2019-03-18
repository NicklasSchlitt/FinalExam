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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Customersbtn
            // 
            this.Customersbtn.Location = new System.Drawing.Point(12, 139);
            this.Customersbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Customersbtn.Name = "Customersbtn";
            this.Customersbtn.Size = new System.Drawing.Size(193, 75);
            this.Customersbtn.TabIndex = 0;
            this.Customersbtn.Text = "Customers";
            this.Customersbtn.UseVisualStyleBackColor = true;
            this.Customersbtn.Click += new System.EventHandler(this.Customersbtn_Click);
            // 
            // Partsbtn
            // 
            this.Partsbtn.Location = new System.Drawing.Point(211, 139);
            this.Partsbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Partsbtn.Name = "Partsbtn";
            this.Partsbtn.Size = new System.Drawing.Size(193, 75);
            this.Partsbtn.TabIndex = 1;
            this.Partsbtn.Text = "Parts";
            this.Partsbtn.UseVisualStyleBackColor = true;
            this.Partsbtn.Click += new System.EventHandler(this.Partsbtn_Click);
            // 
            // Invoicesbtn
            // 
            this.Invoicesbtn.Location = new System.Drawing.Point(211, 218);
            this.Invoicesbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Invoicesbtn.Name = "Invoicesbtn";
            this.Invoicesbtn.Size = new System.Drawing.Size(193, 75);
            this.Invoicesbtn.TabIndex = 2;
            this.Invoicesbtn.Text = "Invoices";
            this.Invoicesbtn.UseVisualStyleBackColor = true;
            this.Invoicesbtn.Click += new System.EventHandler(this.Invoicesbtn_Click);
            // 
            // Vehiclesbtn
            // 
            this.Vehiclesbtn.Location = new System.Drawing.Point(12, 218);
            this.Vehiclesbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vehiclesbtn.Name = "Vehiclesbtn";
            this.Vehiclesbtn.Size = new System.Drawing.Size(193, 75);
            this.Vehiclesbtn.TabIndex = 3;
            this.Vehiclesbtn.Text = "Vehicles";
            this.Vehiclesbtn.UseVisualStyleBackColor = true;
            this.Vehiclesbtn.Click += new System.EventHandler(this.Vehiclesbtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-3, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(1247, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // RevenueLabel
            // 
            this.RevenueLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RevenueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RevenueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RevenueLabel.Location = new System.Drawing.Point(12, 295);
            this.RevenueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RevenueLabel.Name = "RevenueLabel";
            this.RevenueLabel.Size = new System.Drawing.Size(392, 42);
            this.RevenueLabel.TabIndex = 6;
            this.RevenueLabel.Text = "Monthly Revenue: +$536.32";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(117, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 105);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // JoesCRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(413, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RevenueLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Vehiclesbtn);
            this.Controls.Add(this.Invoicesbtn);
            this.Controls.Add(this.Partsbtn);
            this.Controls.Add(this.Customersbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JoesCRM";
            this.Text = "Joe\'s Automotive";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Customersbtn;
        private System.Windows.Forms.Button Partsbtn;
        private System.Windows.Forms.Button Invoicesbtn;
        private System.Windows.Forms.Button Vehiclesbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label RevenueLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

