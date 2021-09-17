using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_05;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = "";
            UtilityClass.PrintHeader("* * * * * * Определение последовательностей * * * * * *");
            Console.Write("Введите последовательность: ");
            sequence = Console.ReadLine();
            Console.WriteLine(DetermineSeq(sequence));
            Console.ReadLine();
        }

        private static string DetermineSeq(string sequence)
        {
            bool isSequenceA = false, isSequenceGeo = false;
            string result = "";
            int count = 0, a1 = 0, a2 = 0, d = 0, q = 0;
            char[] charSeparator = new char[] { ',', ' ' };
            string[] text = sequence.Split(charSeparator, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in text)
            {
                if (count == 0)
                {
                    int.TryParse(item, out a1);
                }
                else
                {

                    //    a1 = a2;
                    int.TryParse(item, out a2);
                    if (count == 1)
                    {
                        d = a2 - a1;
                        if (a1 != 0)
                            q = a2 / a1;
                    }

                    if (a2 == (a1 + d * (count)))
                    {
                        isSequenceA = true;
                        isSequenceGeo = false;
                    }
                    else if (a2 == (a1 * Math.Pow(q, count)))
                    {
                        isSequenceGeo = true;
                        isSequenceA = false;
                    }
                    else
                    {
                        isSequenceA = false;
                        isSequenceGeo = false;
                        break;
                    }
                }

                count++;
            }
            if (isSequenceA)
            {
                result = "Это арифметическая последовательность!";
            }
            else if (isSequenceGeo)
            {
                result = "Это геометрическая последовательность!";
            }
            else
            {
                result = "Это не последовательность!";
            }
            return result;
        }
    }
}
