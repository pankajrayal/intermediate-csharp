using System;

namespace PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1986, 04, 15));
            Console.WriteLine(person.Birthdate);
        }
    }
}
