using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace _1
    {
        class Point
        {
            private int q, w;//Обьявление переменных
            public Point()// Конструктор по умолчанию
            {

            }
            public Point(int q, int w)//Конструктор с параметрами
            {
                this.q = q;
                this.w = w;
            }
            public double qwe()
            {
                return Math.Sqrt(Math.Pow(q, 2) + Math.Pow(w, 2));//Вывод формулы
            }
            ~Point()//Деструктор
            {
            }
        }
    }
}
