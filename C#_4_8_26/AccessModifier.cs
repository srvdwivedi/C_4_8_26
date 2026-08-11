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

// In this example, the AccessModifier class has a private field _name that can only be accessed through the public methods SetName and GetName.
// The SetName method allows you to set the value of _name, while the GetName method allows you to retrieve the value of _name.
// This encapsulation ensures that the _name field cannot be accessed or modified directly from outside the class, providing better control over how the data is accessed and modified.
// The use of access modifiers (private, public, protected, internal) in C# helps to define the accessibility of classes, methods, and fields, allowing for better encapsulation and data hiding.

