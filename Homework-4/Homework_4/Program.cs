using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 4 *«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
            string[,] array = {
                        { "   ",   "А", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И", "К"},
                        { " 1|", "o", "o", "o", "x", "o", "o", "o", "x", "o", "o"},
                        { " 2|", "x", "o", "o", "o", "o", "o", "o", "o", "o", "o"},
                        { " 3|", "x", "o", "o", "x", "x", "x", "x", "o", "o", "o"},
                        { " 4|", "o", "o", "o", "o", "o", "o", "o", "x", "x", "x"},
                        { " 5|", "o", "x", "x", "o", "o", "o", "o", "o", "o", "o"},
                        { " 6|", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o"},
                        { " 7|", "o", "o", "o", "o", "o", "o", "x", "o", "o", "o"},
                        { " 8|", "o", "o", "o", "x", "o", "o", "x", "o", "o", "o"},
                        { " 9|", "o", "o", "o", "o", "o", "o", "x", "o", "o", "o"},
                        {"10|", "o", "x", "x", "o", "o", "o", "o", "o", "x", "o"}};

            Console.WriteLine("Морской бой: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
