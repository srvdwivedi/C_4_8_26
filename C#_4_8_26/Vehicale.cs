using System;
using System.Collections.Generic;
using System.Text;

namespace C__4_8_26
{
    public class Vehicale
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("The vehicale is starting.");

        }

        public void Stop()

        {
            Console.WriteLine("The vehicale is stopping.");
        }
    }

}
