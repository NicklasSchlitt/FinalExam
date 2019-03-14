using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class JoesCRM : Form
    {
        public JoesCRM()
        {
            InitializeComponent();
        }

        private void Customersbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers CustomersForm = new Customers();
            CustomersForm.Show(this);
        }

        private void Vehiclesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicles vehiclesForm = new Vehicles();
            vehiclesForm.Show(this);
        }

        private void Partsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parts PartsForm = new Parts();
            PartsForm.Show(this);
        }

        private void Invoicesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoices InvoicesForm = new Invoices();
            InvoicesForm.Show(this);
        }
    }
}
