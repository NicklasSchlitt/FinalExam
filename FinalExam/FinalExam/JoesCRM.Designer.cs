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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Customersbtn
            // 
            this.Customersbtn.Location = new System.Drawing.Point(121, 93);
            this.Customersbtn.Name = "Customersbtn";
            this.Customersbtn.Size = new System.Drawing.Size(179, 57);
            this.Customersbtn.TabIndex = 0;
            this.Customersbtn.Text = "Customers";
            this.Customersbtn.UseVisualStyleBackColor = true;
            this.Customersbtn.Click += new System.EventHandler(this.Customersbtn_Click);
            // 
            // Partsbtn
            // 
            this.Partsbtn.Location = new System.Drawing.Point(121, 219);
            this.Partsbtn.Name = "Partsbtn";
            this.Partsbtn.Size = new System.Drawing.Size(179, 57);
            this.Partsbtn.TabIndex = 1;
            this.Partsbtn.Text = "Parts";
            this.Partsbtn.UseVisualStyleBackColor = true;
            this.Partsbtn.Click += new System.EventHandler(this.Partsbtn_Click);
            // 
            // Invoicesbtn
            // 
            this.Invoicesbtn.Location = new System.Drawing.Point(121, 282);
            this.Invoicesbtn.Name = "Invoicesbtn";
            this.Invoicesbtn.Size = new System.Drawing.Size(179, 57);
            this.Invoicesbtn.TabIndex = 2;
            this.Invoicesbtn.Text = "Invoices";
            this.Invoicesbtn.UseVisualStyleBackColor = true;
            this.Invoicesbtn.Click += new System.EventHandler(this.Invoicesbtn_Click);
            // 
            // Vehiclesbtn
            // 
            this.Vehiclesbtn.Location = new System.Drawing.Point(121, 156);
            this.Vehiclesbtn.Name = "Vehiclesbtn";
            this.Vehiclesbtn.Size = new System.Drawing.Size(179, 57);
            this.Vehiclesbtn.TabIndex = 3;
            this.Vehiclesbtn.Text = "Vehicles";
            this.Vehiclesbtn.UseVisualStyleBackColor = true;
            this.Vehiclesbtn.Click += new System.EventHandler(this.Vehiclesbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Joe\'s Automotive";
            // 
            // JoesCRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(434, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vehiclesbtn);
            this.Controls.Add(this.Invoicesbtn);
            this.Controls.Add(this.Partsbtn);
            this.Controls.Add(this.Customersbtn);
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
        private System.Windows.Forms.Label label1;
    }
}

