using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Макаревич_Владислав_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double n = double.Parse(textBox1.Text);
            if (radioButton1.Checked) { n = n * 1000; }//при выборе этого радиобатона метры переводятся милиметры
            if (radioButton2.Checked) { n = n * 100; }//при выборе этого радиобатона метры переводятся сантиметры
            if (radioButton3.Checked) { n = n; }//при выборе этого радиобатона метры остаются метрами
            if (radioButton4.Checked) { n = n / 1000; }//при выборе этого радиобатона метры переводятся километры
            if (checkBox1.Checked == true) { textBox2.Text = Convert.ToString(n * 39.7); }//при включенном чекбоксе перевод в дюймы
            if (checkBox2.Checked == true) { textBox3.Text = Convert.ToString(n * 1.094); }//при включенном чекбоксе перевод в футы
            if (checkBox3.Checked == true) { textBox4.Text = Convert.ToString(n * 3.281); }//при включенном чекбоксе перевод в ярды
            if (checkBox4.Checked == true) { textBox5.Text = Convert.ToString(n / 1609); }//при включенном чекбоксе перевод в мили
        }

    }
}
