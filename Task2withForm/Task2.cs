using System;
using System.IO;
using System.Collections.Generic;


namespace task2
{
    class Program
    {
        static void Main()
        {
            StreamWriter w = new StreamWriter("text.txt");
            Console.WriteLine("Введите числа: ");
            string write = Console.ReadLine();
            while (write != "")
            {
                w.WriteLine(Convert.ToInt32(write));
                write = Console.ReadLine();
            }
            w.Close();

            int sum = 0;
            List<int> number = new List<int>();
            StreamReader f = new StreamReader("text.txt");
            while ((write = f.ReadLine()) != null)
            {
                int i = Convert.ToInt32(write);
                sum += i;
                number.Add(i);
            }
            Console.WriteLine("Сумма чисел {0}", sum);
            Console.WriteLine("Всего чисел {0}", number.Count);
        }
    }
}

