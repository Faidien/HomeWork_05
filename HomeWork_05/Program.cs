using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            string name = "* * * * * * Вычисления с матрицами * * * * * *";
            Console.SetCursorPosition(Console.WindowWidth / 2 - name.Length, 0);
            Console.WriteLine(name);
            bool isExit = false;
            byte userAnswer = 0;
            int[,] matrix = new int[5, 5];
            int[,] matrix1 = new int[5, 5];
            int[,] resultMatrix = new int[5, 5];

            while (!isExit)
            {
                Console.WriteLine("Сделайте выбор функции преобразования:");
                Console.WriteLine("1. Умножение матрицы на число\n2. Сложение матриц\n3. Вычитание матриц\n4. Умножение двух матриц\n5. Выход из программы");
                byte.TryParse(Console.ReadLine(), out userAnswer);
                Console.WriteLine();
                switch (userAnswer)
                {
                    case 1:
                        Console.WriteLine("Умножение матрицы на число:");
                        int num = 0;
                        Console.Write("Введите число для умножения: ");
                        int.TryParse(Console.ReadLine(), out num);
                        PrintMatrix(InitMatrix(matrix, r), "Исходная матрица:");
                        PrintMatrix(MatrixMultiplicationWithNum(matrix, num), "Преобразованная матрица: ");
                        break;
                    case 2:
                        Console.WriteLine("Сложение матриц:");
                        PrintMatrix(InitMatrix(matrix, r), "Исходная 1 матрица:");
                        PrintMatrix(InitMatrix(matrix1, r), "Исходная 2 матрица:");
                        PrintMatrix(MatrixAddition(matrix, matrix1), "Результат сложения матриц: ");
                        break;

                    case 3:
                        Console.WriteLine("Вычитание матриц:");
                        PrintMatrix(InitMatrix(matrix, r), "Исходная 1 матрица:");
                        PrintMatrix(InitMatrix(matrix1, r), "Исходная 2 матрица:");
                        PrintMatrix(MatrixSubtraction(matrix, matrix1), "Результат вычитания матриц: ");
                        break;

                    case 4:
                        Console.WriteLine("Перемножение матриц:");
                        PrintMatrix(InitMatrix(matrix, r), "Исходная 1 матрица:");
                        PrintMatrix(InitMatrix(matrix1, r), "Исходная 2 матрица:");
                        PrintMatrix(MatrixMultiplication(matrix, matrix1), "Результат перемножения матриц: ");
                        break;
                    case 5:
                        isExit = true;
                        break;
                    default:
                        break;
                }

            }
        }

        /// <summary>
        /// Вычитание матрицы 2 из матрицы 1
        /// </summary>
        /// <param name="matrix">1 матрица</param>
        /// <param name="matrix1">2 матрица</param>
        /// <returns></returns>
        static int[,] MatrixSubtraction(int[,] matrix, int[,] matrix1)
        {
            int[,] convertMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    convertMatrix[i, j] = matrix[i, j] - matrix1[i, j];
                }
            }
            return convertMatrix;
        }

        /// <summary>
        /// Инициализация  массива
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        static int[,] InitMatrix(int[,] matrix, Random r)
        {
            //Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(5, 50);
                }
            }
            return matrix;
        }
        /// <summary>
        /// Умножение матрицы на число
        /// </summary>
        /// <param name="matrix">Матрица</param>
        /// <param name="num">Число, на которое умножится матрица</param>
        /// <returns></returns>
        static int[,] MatrixMultiplicationWithNum(int[,] matrix, int num)
        {
            int[,] convertMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    convertMatrix[i, j] = matrix[i, j] * num;
                }
            }

            return convertMatrix;
        }
        static int[,] MatrixMultiplication(int[,] matrix, int[,] matrix1)
        {
            int[,] convertMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        //Console.WriteLine(matrix[i, k] + " * " + matrix1[k, j]);
                        convertMatrix[i, j] += matrix[i, k] * matrix1[k, j];
                    }

                }
            }
            return convertMatrix;
        }

        /// <summary>
        /// Сложение матриц
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="matrix1"></param>
        /// <returns></returns>
        static int[,] MatrixAddition(int[,] matrix, int[,] matrix1)
        {
            int[,] convertMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    convertMatrix[i, j] = matrix[i, j] + matrix1[i, j];
                }
            }

            return convertMatrix;
        }
        /// <summary>
        /// Печать на экран матрицы
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="text"></param>
        static void PrintMatrix(int[,] matrix, string text = "")
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(text);
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
        }
    }
}