﻿using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. Написать программу, выводящую элементы двумерного массива по диагонали.
            int[,] array = { { 1, 2 }, { 3, 4 } };
            for(int i = 0; i < array.GetLength(0); i++ )
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine($"{array[i, j]}");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
