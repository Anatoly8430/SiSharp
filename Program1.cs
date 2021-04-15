using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Task1 
{ /// <summary>
/// Афанасьев Анатолий. Задача 1. Условие:Написать метод, возвращающий минимальное из трех чисел.
/// </summary>
    class Program

    {




        private static void Main (string[] args)
        {




            int x1;
            int x2;
            int x3;



            Console.Write("Введите значение x1: ");
            string s = Console.ReadLine();
            x1 = int.Parse(s);

            Console.Write("Введите значение x2: ");
            string s1 = Console.ReadLine();
            x2 = int.Parse(s1);



            Console.Write("Введите значение x3: ");
            string s3 = Console.ReadLine();
            x3 = int.Parse(s3);

            if (x1 < x2 && x1 < x3)
            {
                Console.Write(x1);
                Console.ReadLine();
            }
            else if (x2 < x1 && x2 < x3)
            {
                Console.Write(x2);
                Console.ReadLine();
            }
            else if (x3 < x1 && x3 < x2)
            {
                Console.Write(x3);
                Console.ReadLine();
            }
        }
    }

    
    }



