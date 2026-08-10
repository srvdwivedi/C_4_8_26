using System;

namespace C__4_8_26
{

    public class Program
    {
        static void Main(string[] args)
        {
            //var point = new Point(10, 20);
            //point.Move(30, 40);
            //Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            //point.Move(100, 200);
            //Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            var calculator = new Calculator();
            var result = calculator.Add(1, 2, 3, 4, 5);
            Console.WriteLine("Addition result: {0}", result);
        }

    }
}