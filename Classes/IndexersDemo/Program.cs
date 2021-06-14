using System;

namespace IndexersDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Pankaj";
            Console.WriteLine(cookie["name"]);
        }
    }
}