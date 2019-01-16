using System;
using System.Collections.Generic;

namespace DelagateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var peeps = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Fred",
                    LastName = "Flinstone"
                },
                new Employee
                {
                    FirstName = "Barney",
                    LastName = "Rubble"
                },
                new Employee
                {
                    FirstName = "BamBam",
                    LastName = "Rubble"
                }
            };

            peeps.Sort();
            foreach(var emp in peeps)
            {
                Console.WriteLine($"First:{emp.FirstName}, Last:{emp.LastName}");
            }
        }
    }
}
