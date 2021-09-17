using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_05;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            long n, m;
            UtilityClass.PrintHeader("* * * * * * Функия Аккермана * * * * * *");
            Console.Write("Введите число n: ");
            long.TryParse(Console.ReadLine(), out n);
            Console.Write("Введите число m: ");
            long.TryParse(Console.ReadLine(), out m);
            string res = (A(n, m)).ToString();
            Console.WriteLine(res);
            Console.ReadLine();
        }
        static long A(long n, long m)
        {
            if (n == 0)
            {
                return m + 1L;

            }
            else if (n != 0 && m == 0)
            {
                return A(n - 1L, 1L);
            }
            else
            {
                return A(n - 1L, A(n, m - 1L));
            }
        }
    }
}