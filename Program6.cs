using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{/// <summary>
/// Афанасьев. Задача 6. Условие*Написать программу подсчета количества «Хороших» 
/// чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. 
/// Реализовать подсчет времени выполнения программы, используя структуру DateTime.
/// </summary>
    class Program
    {
        static int NumSumm(int n) // создал метод подсчета суммы  цифр числа
        {
            int s = 0;
            while (n != 0) 
            {
                s = s + n % 10;
                n = n / 10;
            }
            return s;
        }

        static bool GoodNum (int n) //создал метод проверки числа на хорошесть
        {
            return n % NumSumm(n) == 0;
        }



        static void Main(string[] args)
        {
            int a = 0; // объявлена и инициализирована переменная счетчик
            DateTime start = DateTime.Now; // начался отсчет времени

            for (int j=1; j <= 1000000000; j++) //заданы параметры цикла
            { if ( GoodNum(j)) // если число хорошее
                {
                    Console.WriteLine(j); //то оно выводится на экран
                    a++; // и засчитывается

                }

            }
            DateTime finish = DateTime.Now; //конец отсчета времени
            Console.WriteLine("Количество хороших чисел составляет: " + a); //вывод результатов
            Console.ReadLine();
            Console.WriteLine("Время потраченное на реализацию подсчета составляет: " + (finish - start));
            Console.ReadLine();
        }
    }
}
