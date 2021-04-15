using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{/// <summary>
/// Афанасьев. Задача 4.  Реализовать метод проверки логина и пароля.
/// На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, 
/// если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля,
/// написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
/// С помощью цикла do while ограничить ввод пароля тремя попытками.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;

            do
            {
                n++;
                Console.Write(" Введите логин: ");
                string a = (Console.ReadLine());

                


                Console.Write(" Введите пароль: ");
                string b = (Console.ReadLine());

                

                if (a == "root" && b == "GeekBrains")
                {
                    Console.Write(" Поздравляем Вы вошли ");
                    Console.ReadLine();
                    break;
                    


                }
                else
                {
                    Console.Write(" Логин или пароль набран неверно ");


                    
                }
            } while (n <= 2);
        }
    }
}
