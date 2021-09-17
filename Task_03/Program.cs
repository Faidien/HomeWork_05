using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_05;
namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            UtilityClass.PrintHeader("* * * * * * Операции с текстом * * * * * *");
            Console.Write("Введите текст: ");
            text = Console.ReadLine();

            Console.WriteLine("Слово с минимальной длинной: " + DeleteDoubleFromWord(text.ToLower()));
            Console.ReadLine();
        }

        /// <summary>
        /// Возвращает строку без дубликатов
        /// </summary>
        /// <param name="text"></param>
        private static string DeleteDoubleFromWord(string text)
        {
            string result = "";
            char c = ' ';
            foreach (char item in text)
            {
                if (c == ' ')
                {
                    c = item;
                    result += c;
                }
                else
                {
                    if (c != item)
                    {
                        c = item;
                        result += c;
                    }
                }
            }
            return result;
        }
    }
}
