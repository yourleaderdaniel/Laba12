using Shared;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                
                if (!context.Users.Any())
                {
                    var users = new List<User>
                    {
                        new User { FirstName = "John", LastName = "Doe", Age = 30 },
                        new User { FirstName = "Jane", LastName = "Doe", Age = 25 },
                        new User { FirstName = "Bob", LastName = "Smith", Age = 28 }
                    };
                    context.Users.AddRange(users);
                    context.SaveChanges();
                }

                
                var fetchedUsers = context.Users.ToList();
                foreach (var user in fetchedUsers)
                {
                    Console.WriteLine($"User: {user.FirstName} {user.LastName}, Age: {user.Age}");
                }
            }
        }
    }
}
