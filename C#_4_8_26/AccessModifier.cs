using System;
using System.Collections.Generic;
using System.Text;

namespace C__4_8_26
{
    public class AccessModifier
    {
        private string _name;

        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name)) //using getter & setter function help to add validation which we cannot do with variable directly
                this._name = name;
        }

        public void GetName()
        {
            Console.WriteLine("Name: {0}", this._name);
        }
    }
}
