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
    public partial class Parts : Form
    {
        
        

        

        public Parts()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoesCRM joes = new JoesCRM();
            joes.Show(this);
        }

        private void Parts_Load(object sender, EventArgs e)
        {
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0) //when bike is selected
            {
                pictureBox1.Visible = true; // shows bike
                pictureBox2.Visible = false;// hides tahoe
                pictureBox3.Visible = false;// hides F350
                pictureBox4.Visible = false;// hides VW minibus
            }
            if (comboBox2.SelectedIndex == 1) //when tahoe is selected
            {
                pictureBox1.Visible = false;// hides bike
                pictureBox2.Visible = true; // shows tahoe 
                pictureBox3.Visible = false;// hides F350
                pictureBox4.Visible = false;// hides VW minibus
            }
            if (comboBox2.SelectedIndex == 2) // when F350 is selected
            {
                pictureBox1.Visible = false;// hides bike
                pictureBox2.Visible = false;// hides tahoe
                pictureBox3.Visible = true; // shows F350
                pictureBox4.Visible = false;// hides VW minibus
            }
            if (comboBox2.SelectedIndex == 3) // when VW minibus is selected
            {
                pictureBox1.Visible = false;// hides bike
                pictureBox2.Visible = false;// hides tahoe
                pictureBox3.Visible = false;// hides F350
                pictureBox4.Visible = true; // shows VW minibus
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) // when drive shaft is selected
            {
                pictureBox5.Visible = true;  // shows drive shaft
                pictureBox6.Visible = false; // hides brakes
                pictureBox8.Visible = false; // hides car
                pictureBox7.Visible = false; // hides window
            }
            if (comboBox1.SelectedIndex == 1) // when brakes is selected
            {
                pictureBox5.Visible = false; // hides drive shaft
                pictureBox6.Visible = true;  // shows brakes
                pictureBox8.Visible = false; // hides car
                pictureBox7.Visible = false; // hides window
            }
            if (comboBox1.SelectedIndex == 2) // when car is selected
            {
                pictureBox5.Visible = false; // hides drive shaft
                pictureBox6.Visible = false; // hides brakes
                pictureBox8.Visible = true;  // shows car
                pictureBox7.Visible = false; // hides window
            }
            if (comboBox1.SelectedIndex == 3) // when window is selected
            {
                pictureBox5.Visible = false; // hides drive shaft
                pictureBox6.Visible = false; // hides brakes
                pictureBox8.Visible = false; // hides car
                pictureBox7.Visible = true;  // shows window
            }
        }
    }
}
