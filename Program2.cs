using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{/// <summary>
/// Афанасьев. Задача 2. Условия:  Написать метод подсчета количества цифр числа.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Введите число a: ");
            long a = long.Parse(Console.ReadLine());
            int n = 0;
            while (a > 0)
            {
                a = a / 10;
                n++;
            }
            Console.Write(" Количество цифр  в числе составляет: " + n);
            Console.ReadLine();
        }
    }
}
