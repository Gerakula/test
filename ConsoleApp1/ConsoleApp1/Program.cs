using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class Animal
        {
            protected string name;
            protected int yo;
        }
        class Cat : Animal
        {
            public void qwe()
            {
                yo = 1;
                name = "qwe1";
                Console.WriteLine("Характеристики кота");
                Console.WriteLine(name);
                Console.WriteLine(yo);
            }
        }
        class Dog : Animal
        {
            public void qwer()
            {
                yo = 2;
                name = "qwe2";
                Console.WriteLine("Характеристики собаки");
                Console.WriteLine(name);
                Console.WriteLine(yo);
            }
        }
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.qwe();
            dog.qwer();
            Console.ReadKey();
        }
    }
}
