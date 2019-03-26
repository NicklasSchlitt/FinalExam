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
    public partial class Vehicles : Form
    {
        public string _model;
        public string _year;
        public string _dater;
        public string _mileage;
        public string _customer;

        
        enum Vehicle
        {
            _model,
            _year,
            _dater,
            _mileage,
            _customer

        }
        public Vehicles()
        {
            InitializeComponent();
            
        }
        
        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoesCRM joes = new JoesCRM();
            joes.Show(this);
        }
 
        private void DataEnterButton_Click(object sender, EventArgs e)
        {
            _model = textBox2.Text;
            _year = textBox3.Text;
            _dater = textBox4.Text;
            _mileage = textBox5.Text;
            _customer = textBox1.Text;

            CarsBox.Items.Add(_customer);
            CarsBox.Items.Add(_model);
            CarsBox.Items.Add(_year);
            CarsBox.Items.Add(_mileage);
            CarsBox.Items.Add(_dater);
            CarsBox.Items.Add("________________________________________________________");
        }
    }
}
