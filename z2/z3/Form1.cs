using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z3
{
    public partial class Form1 : Form
    {
        int q,w,r, sum1 =0,sum2=0,sum3=0,z,sum4=0;// оглавление переменных

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            q = int.Parse(textBox1.Text);// присвоение введеного текста в переменную 
            string f = q.ToString();// перевод в стринг для вычисления кол-ва символов 
            for (int i = 0; i < f.Length; i++)// int i = 0, пока i < кол-ва символов в стринге(tekst) цикл работает
            {
                if (q % 10 > 0)// не сильно важный фрагмент в цикле( пока остача переменной больше нуля происходит =>
                {
                    sum1 = sum1 + q % 10;// вычисление суммы цифр в натуральном числе
                }
                q /= 10;// уничтожаем последнюю цифру натурального числа
            }
            //label4.Text = sum1.ToString();
            
            // аналогично
            w = int.Parse(textBox2.Text);
            string g = w.ToString();
            for (int i = 0; i < g.Length; i++)
            {
                if (w % 10 > 0)
                {
                    sum2 = sum2 + w % 10;
                }
                w /= 10;
            }
            //label5.Text = sum2.ToString();
          

            //аналогично
            r = int.Parse(textBox3.Text);
            string h = r.ToString();
            for (int i = 0; i < h.Length; i++)
            {
                if (r %10 > 0)
                {
                    sum3 = sum3 + r % 10;
                }
                r /= 10;
            }
            //label6.Text = sum3.ToString();
            
            
            z = sum1 + sum2 + sum3;// сумируем все числа которые получились и проводим аналогичный цикл для полученого числа 
            string x = z.ToString();
            for (int i = 0; i < x.Length; i++)
            {
                if (z % 10 > 0)
                {
                    sum4 = sum4 + z % 10;
                }
                z /= 10;
            }
            label7.Text = sum4.ToString();
            // это для удобства анулировал по красоте, вдруг миссклик)
            sum4 = 0;
            sum1 = 0;
            sum2 = 0;
            sum3 = 0;
        }
    }
}




