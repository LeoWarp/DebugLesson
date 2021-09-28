using System;

namespace DebugLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            var name = Console.ReadLine();
            
            // Нужно вывести все данные пользователя
            var user = GetUser(name);
            Console.WriteLine($"Имя пользователя - {user.Name} | Возраст пользователя - {user.Age}");

            Console.WriteLine(new string('-', 25));
            UserService.Print();
        }

        private static User GetUser(string name)
        {
            var user = UserService.GetUser(name);
            if (user != null)
                return user;

            return null;
        }
    }
}