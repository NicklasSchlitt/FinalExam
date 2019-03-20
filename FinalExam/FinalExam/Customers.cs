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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        
        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoesCRM joes = new JoesCRM();
            joes.Show(this);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void RemveNmeBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        

        private void Customers_Load(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\000131184\Documents\GitHub\FinalExam\FinalExam\FinalExam\Customersdatabase.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            int rowIndex = -1;
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[row.Index].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        dataGridView1.Rows[row.Index].Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
