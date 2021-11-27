using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tack4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int rez = 0;
            for (int i = 1, j = 1; i <= (2 * n - 1); i += 2, j++)
            {

                rez += i;
                Console.WriteLine("Квадрат числа {0} равен {1}", j, rez);
            }
            Console.ReadKey();




        }
    }
}


