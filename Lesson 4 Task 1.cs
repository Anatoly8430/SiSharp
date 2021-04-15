using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Task_1
{
    /// <summary>
    /// АфанасьевАВ  Условие задачи: Дан  целочисленный  массив  из 20 элементов. 
    /// Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
    /// Заполнить случайными числами. 
    /// Написать программу, позволяющую найти и вывести количество пар элементов массива, 
    /// в которых только одно число делится на 3. В данной задаче под парой подразумевается
    /// два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

    /// </summary>
    class MyArray
    {
        int[] a;
        //  Создал массив и заполнил его одним значением el  
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        //  Создал массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        

        public int  Search // метод подсчета пар
        {
            get
            {
                int s = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > 0 && a[i] % 3 == 0 && a[i + 1]%3 != 0 && a[i-1]%3 != 0)
                    {
                        s++;
                    }
                    
                }
                s = s * 2;

                return s;

            }
        }
        
        
        public override string ToString() //метод вывода на экран
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(20, -10, 10);
            Console.WriteLine(a.ToString());
            
            Console.WriteLine(a.Search);
            Console.ReadLine();
        }
    }

}
    

