using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            UtilityClass.PrintHeader("* * * * * * Операции с текстом * * * * * *");
            Console.Write("Введите текст: ");
            text = Console.ReadLine();

            Console.WriteLine("Слово с минимальной длинной: " + ReturnMinWord(text));
            Console.WriteLine("Слова с маскимальной длинной: ");
            foreach (var item in ReturnMaxWords(text))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Возвращает минимальное слово из текста  в параметре
        /// </summary>
        /// <param name="text"></param>
        private static string ReturnMinWord(string text)
        {
            string[] result;
            int min = 0, numMin = 0, count = 0;
            char[] separator = new char[] { ' ', ',', '.', '!', '?' };
            result = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in result)
            {
                if (min == 0)
                {
                    min = item.Length;
                    numMin = 0;
                }
                else
                {
                    if (min > item.Length)
                    {
                        min = item.Length;
                        numMin = count;
                    }
                }
                count++;
            }
            return result[numMin];
        }
        private static string[] ReturnMaxWords(string text)
        {
            string[] result;
            string[] resultReturn;
            string res = "";
            int max = 0;
            char[] separator = new char[] { ' ', ',', '.', '!', '?' };
            result = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            resultReturn = new string[result.Length];
            foreach (var item in result)
            {
                if (max == 0)
                {
                    max = item.Length;
                }
                else
                {
                    if (max < item.Length)
                    {
                        max = item.Length;
                    }
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Length == max)
                {
                    res += result[i] + ",";
                }
            }
            resultReturn = res.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            return resultReturn;

        }
    }
}
        