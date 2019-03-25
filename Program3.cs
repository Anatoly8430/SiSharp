using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {/// <summary>
     /// Афанасьев. Задача 3 . Условие: С клавиатуры вводятся числа, пока не будет введен 0. 
     /// Подсчитать сумму всех нечетных положительных чисел.
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a;
            int b = 0;
            do
            {
                Console.Write(" Введите число  : ");
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    break;
                }
                else if ( a%2 != 0)
                {
                    b = b + a;
                }
            } while (true);

            Console.Write(" Cумма чисел составляет:  " + b);
            Console.ReadLine();
        }
    }
}
