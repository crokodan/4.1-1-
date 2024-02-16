using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Задание_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 12;
            int count = 0;
            double[] a = new double[n];
            double sum = 0.0;
            Console.WriteLine("Ввести " + n + " Число:");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] < a[n - 1])
                {
                    count++;
                    sum += a[i];
                }
            }
            Console.WriteLine("Колличество=" + count);
            if (count > 0)
            {
                Console.WriteLine("Сумма = " + sum);
            }
            else
            {
                Console.WriteLine("Элемент отсутствует");
            }
            Console.ReadLine();
        }
    }
}
