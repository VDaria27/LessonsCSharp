using System;

namespace Lesson1Task1
{
    class Program
    { 
        static void Main(string[] args)
        {
            System.Console.WriteLine("Как Вас зовут?");
            System.Console.Write("Введите Ваше имя, пожалуйста: ");
            string name = Console.ReadLine();
            string date = DateTime.Now.ToShortDateString();
            System.Console.WriteLine($"Привет, {name}, сегодня {date} года!");
        }
    }
}