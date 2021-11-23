using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçak_Bilet_Rezervasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox5.Text);
            listBox1.Items.Add(maskedTextBox1.Text);
            listBox1.Items.Add(maskedTextBox2.Text);
            listBox1.Items.Add(textBox2.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(comboBox2.Text);
            listBox1.Items.Add(dateTimePicker1.Text);
            listBox1.Items.Add(dateTimePicker2.Text);
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(comboBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label16.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label16.Text;
            
        }
    }
}
