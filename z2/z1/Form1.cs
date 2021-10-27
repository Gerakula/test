using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();// закрытие формы с помощью кнопки
        }

        public void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();// создать форму с помощью кнопки смог, а где теперь эта форма я не знаю)
            f.Show();// выовод формы на екран
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                double x1, x2, x3, y1, y2, y3, l1, l2, l3, S, p;// оглавление переменных
                x1 = double.Parse(textBox3.Text);// присвоение введеного текста в переменную типа дабл/////////
                x2 = double.Parse(textBox1.Text);//
                x3 = double.Parse(textBox5.Text);//
                y1 = double.Parse(textBox4.Text);//
                y2 = double.Parse(textBox2.Text);//
                y3 = double.Parse(textBox6.Text);////////////////////////////////////////////////////
                l1 = Math.Sqrt(Math.Abs(Math.Pow((x2 - x1), 2) - Math.Pow(((y2 - y1)), 2)));// вычисление сторон треугольника
                l2 = Math.Sqrt(Math.Abs(Math.Pow((x3 - x2), 2) - Math.Pow(((y3 - y2)), 2)));//
                l3 = Math.Sqrt(Math.Abs(Math.Pow((x3 - x1), 2) - Math.Pow(((y3 - y1)), 2)));/////////////////////////////////
                p = (l1 + l2 + l3) / 2;// полупериметр
                S = Math.Sqrt(Math.Abs((p * (p - l1) * (p - l2) * (p - l3))));// площдь треугольника
                label3.Text = S.ToString();//  вывод числа в типе стринг в 3 лабелку


        }
        private void button4_Click(object sender, EventArgs e)
        {
           
                double x1, x2, x3, y1, y2, y3, l1, l2, l3, P;
                x1 = double.Parse(textBox3.Text);// присвоение введеного текста в переменную типа дабл/////////
                x2 = double.Parse(textBox1.Text);//
                x3 = double.Parse(textBox5.Text);//
                y1 = double.Parse(textBox4.Text);//
                y2 = double.Parse(textBox2.Text);//
                y3 = double.Parse(textBox6.Text);//
                l1 = Math.Sqrt(Math.Abs(Math.Pow((x2 - x1),2) - Math.Pow(((y2 - y1)),2)));// вычисление сторон треугольника
                l2 = Math.Sqrt(Math.Abs(Math.Pow((x3 - x2), 2) - Math.Pow(((y3 - y2)), 2)));//
                l3 = Math.Sqrt(Math.Abs(Math.Pow((x3 - x1), 2) - Math.Pow(((y3 - y1)), 2)));//
                P = l1 + l2 + l3;// периметр
                label4.Text = P.ToString();// вывод числа в типе стринг в 4 лабелку
        }
        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
