using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Models
{
    internal class Person
    {
        public string name;
        public string surname;
        public int age;

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public void Fullname()
        {
            Console.WriteLine($"{name} {surname}");
        }
        public int GetAge()
        {
            return age;
        }
    }
}
