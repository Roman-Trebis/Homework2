using System;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 3. Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).
            Console.Write("Введите строку: ");
            string line = Console.ReadLine();

            Console.Write("Обратный порядок строки: ");
            for (int i = line.Length - 1; i >= 0; i--)
            {
                Console.Write(line[i]);
            }
        }
    }
}
