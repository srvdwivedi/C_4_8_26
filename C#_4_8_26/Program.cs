using System;

namespace C__4_8_26
{

    public class Program
    {
        static void Main(string[] args)

        {
            UseCar();
        }


        static void UseCar()
        {
            try
            {
                var car = new Car();
                car.FuelType();
                car.NumberOfDoors();
                car.Start();
            }
            catch (Exception)
            {
                throw;
            }
        }

        static void UseProperties()
        {
            try
            {
                var person = new PropertiesAM();
                person.Name = "Sourav Dwivedi";
                Console.WriteLine(person.Name);
                person.Description = "Software Developer";
                Console.WriteLine(person.Description);
            }
            catch (Exception)
            {
                throw;
            }
        }

        static void UseAccessModifier()
        {
            try
            {
                var person = new AccessModifier();
                person.SetName("Sourav Dwivedi");
                person.GetName();
            }
            catch (Exception)
            {
                throw;
            }
        }

        static void UseCalculator()
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Add(1, 2, 3, 4, 5);
                Console.WriteLine("Addition result: {0}", result);
            }
            catch (Exception)
            {
                throw;
            }
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(30, 40);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}