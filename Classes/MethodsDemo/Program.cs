using System;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("abc");
            int number;
            //var result = int.TryParse("abc", out number);
            var result = int.TryParse("100", out number);

            if (result)
            {
                Console.WriteLine(number);
            } else
            {
                Console.WriteLine("Conversation failed");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 90 }));

        }

        static void UsePoints()
        {
            var point1 = new Point(10, 20);
            point1.Move(new Point(40, 60));

            Console.WriteLine("Point is at ({0}, {1})", point1.X, point1.Y);

            var point2 = new Point(10, 20);
            point2.Move(100, 200);
            Console.WriteLine("Point is at ({0}, {1})", point2.X, point2.Y);

            // testing null exception error
            //point2.Move(null);    

            try
            {
                point2.Move(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception error occurred!");
            }
        }
    }
}
