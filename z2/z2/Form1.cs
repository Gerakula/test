using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;// оглавление переменных
            a = int.Parse(textBox1.Text);// присвоение введеного текста в переменную 
            b = int.Parse(textBox2.Text);// присвоение введеного текста в переменную 
                if (b == 0)// если знаменатель равняется нулю то выдаст ошибку
                {
                    MessageBox.Show("Error:На ноль делить нельзя");
                }
                else// в обратном случае
                {
                    c = a / b;// формула
                    label4.Text = c.ToString();// вывод числа в типе стринг в 4 лабелку
                    c = 0;
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
