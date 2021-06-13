using System;

namespace Classes
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}.", to, Name);
        }

        public Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }

        // static method
        public static Person Parse1(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            var person = new Person();
            person.Name = "Ramesh";
            person.Introduce("Pankaj");

            var person1 = new Person();
            var p = person.Parse("Ramesh");
            person.Introduce("Pankaj");

            // calling static method
            var staticPerson = Person.Parse1("Ramesh");
            staticPerson.Introduce("Pankaj");
        }
    }
}
