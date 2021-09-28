using System;
using System.Collections.Generic;
using System.Linq;

namespace DebugLesson
{
    public class User
    {
        public string Name { get; set; }
        
        public int Age { get; set; }
    }
    
    public static class UserServicex
    {
        public static List<User> Users = new List<User>()
        {
            new User() { Name = "Alex", Age = 18 },
            new User() { Name = "Andrey" },
            new User() { Name = "John" }
        };

        public static User GetUser(string name)
        {
            return Users.FirstOrDefault(x => x.Name == name);
        }

        public static void Print()
        {
            Console.WriteLine("Дай угадаю, опять пишешь говнокод? Не говорили только, что нет!");
        }
    }
}