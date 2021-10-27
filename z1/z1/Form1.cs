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
        int x, max=-1;//Оглавление переменных
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try// этот прикол для того что бы человек понял что ввел слишком большое число и что бы программа не ломалась, а то не красиво как-то
            {// попробуем вот это =>
                x = int.Parse(textBox1.Text);// присвоение введеного текста в переменную 
                string f = x.ToString();//перевод в стринг
                for (int i = 0; i < f.Length; i++)// int i = 0, пока i < кол-ва символов в стринге(tekst) цикл работает
                {
                    if (max < x % 10)// если максимальное число(переменная в определенный момент) меньше остачи числа/10 выполянется =>
                    {
                        max = x % 10;// max = остаче всего натурального числа
                    }
                    x /= 10;// делаем введенное число меньше на одну циферку
                }
                label3.Text = max.ToString();// вводим в лабелку переменную max в типе стринг 
                max = 0;// обнуляем строку
            }
            catch// если не получилось то делаем вот это =>
            {
                MessageBox.Show("Error:Недопустимое количество симовлов");// вывод на екран формочки (оповещение об ошибке)
            }
        }
    }
}
