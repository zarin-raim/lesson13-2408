using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(20);

            Random random = new Random();
            int summa = 0;

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < list.Capacity; i++)
            {
                list.Add(random.Next(-20, 20));
                Console.Write(list[i] + " ");
                if (i % 2 == 0)
                    summa += list[i];
            }

            int max = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > list[max])
                {
                    max = i;
                }
            }

            int premax = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (i != max && list[i] != list[max] && list[i] > list[premax])
                {
                    premax = i;
                }
            }


            Console.WriteLine("\n\nВторое максимальное значение: [" + premax + "] : " + list[premax]);

            Console.WriteLine("\nСумма чисел на четных позициях: " + summa);

            Console.ReadLine();
        }
    }
}
