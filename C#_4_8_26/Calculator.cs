using System;
using System.Collections.Generic;
using System.Text;

namespace C__4_8_26
{
    internal class Calculator
    {
        public int Add (params int[] a)
        {
            int sum = 0;
            foreach (var item in a)
            {
                sum += item;
            }
            return sum; 
        }
    }
}
