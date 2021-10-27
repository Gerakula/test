using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);//перевод числа в дабл в текстбоксе 1
            b = Convert.ToDouble(textBox2.Text);//перевод числа в дабл в текстбоксе 2
            c = Convert.ToDouble(textBox4.Text);//перевод числа в дабл в текстбоксе 4
            textBox3.Text = Convert.ToString(((b - a) * (7.1 + 2.12)*c)+"грн");//формула для расчета цены учитывая доставку и обьем помещения
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
