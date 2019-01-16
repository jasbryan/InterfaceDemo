using System;
using System.Collections.Generic;
using System.Text;

namespace DelagateDemo
{
    class Employee : IComparable<Employee>
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public int CompareTo(Employee other)
        {
            if (LastName == other.LastName)
            {
                if (FirstName == other.FirstName) return 0;
                else return FirstName.CompareTo(other.FirstName);
            }
            else return LastName.CompareTo(other.LastName);
        }
    }
}
