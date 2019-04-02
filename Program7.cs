using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {/// <summary>
     /// Афанасьев. Задание 7. Условие:a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
       // *Разработать рекурсивный метод, который считает сумму чисел от a до b.
    /// </summary>
    /// <param name="args"></param>



        static void Main(string[] args)
        { // Рекурсивный метод здесь неэффективен и все можно решить с помощью цикла for

            Console.Write(" Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(" Введите число b: ");
            int b = int.Parse(Console.ReadLine()); // ввожу параметры a b 
            int c = 0; // объявляю и инициализирую переменную суммы чисел
            
            for (int j = a; j <= b; j++) // задаю параметры цикла
            {
                Console.Write(j); // вывод чисел на экран
                c = c + j; // подсчет суммы чисел
            }
            Console.ReadLine();
            Console.WriteLine("Сумма всех чисел выведеных на экран составляет:  " + c ); // вывод результатов
            Console.ReadLine();
        }
    }
}
