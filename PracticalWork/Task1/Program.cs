using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            Random random = new Random();

            for(int i = 0; i < 20; i++)
            {
                list.Add(random.Next(-20, 20));
                Console.Write(list[i] + " ");
            }

            for(int i = 0; i < list.Count; i++)
            {
                if((Math.Abs((int)list[i])) % 2 == 1)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine();
            foreach(int item in list)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
