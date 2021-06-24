using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2. Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/email.
            string[,] array = {
                {"Роман", "+79284319095" },
                {"Виталий", "+79284223947" },
                {"Галина", "galina@mail.ru" },
                {"Аноним 1", "anonym1_anonym@mail.ru" },
                {"Аноним 2", "anonym2_anonym@mail.ru" }};

            Console.WriteLine("Телефонный справочник: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"{array[i, 0]}, {array[i, 1]}");
            }
        }
    }
}
