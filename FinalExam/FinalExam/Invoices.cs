using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalExam
{
    public partial class Invoices : Form
    {
        //Just a little binary for you dockett
        int totalcost = 0b101110100;
        double fluidcheckup = 24.99;
        public Invoices()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoesCRM joes = new JoesCRM();
            joes.Show(this);
        }

        //Displays Database info on datagridview
        private void Invoices_Load(object sender, EventArgs e)
        {
            
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\000131184\Documents\GitHub\FinalExam\FinalExam\FinalExam\Customersdatabase.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Invoices", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt2 = new DataTable())
                        {
                            sda.Fill(dt2);
                            dataGridView1.DataSource = dt2;
                        }
                    }
                }
            }


           label1.Text = "$" + totalcost.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Text = "$" + (totalcost + fluidcheckup).ToString();
            }
            else
            {
                label1.Text = "$" + totalcost.ToString();
            }
        }

        
    }
}
