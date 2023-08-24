using System;
using System.Collections.Generic;
using System.Linq;

namespace N23_HT2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Users = new List<User>
            {
                new User("John", "Doe", "johndoe@example.com"),
                new User("Jane", "Doe", "janedoe@example.com"),
                new User("Bob", "Smith", "bobsmith@example.com"),
                new User("Alice", "Johnson", "alicejohnson@example.com"),
                new User("Mike", "Brown", "mikebrown@example.com"),
                new User("Emily", "Davis", "emilydavis@example.com"),
                new User("David", "Wilson", "davidwilson@example.com"),
                new User("Sarah", "Taylor", "sarahtaylor@example.com"),
                new User("Tom", "Anderson", "tomanderson@example.com"),
                new User("Lisa", "Thomas", "lisathomas@example.com")
            };

            Console.Write("So'zni kiriting: ");
            string key = Console.ReadLine().ToLower();

            var matchingUsers = Users
                .Where(user => user.FirstName.ToLower().Contains(key) || user.LastName.ToLower().Contains(key))
                .Take(5);

            if (matchingUsers.Any())
            {
                Console.WriteLine("\nMa'lumot topildi:");
                foreach (User user in matchingUsers)
                {
                    Console.WriteLine($"{user.FirstName} {user.LastName}, {user.EmailAddress}");
                }
            }
            else
            {
                Console.WriteLine("\nMa'lumot topilmadi.");
            }
        }
    }
}
