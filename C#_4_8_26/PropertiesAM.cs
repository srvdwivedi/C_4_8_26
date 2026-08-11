using System;
using System.Collections.Generic;
using System.Text;

namespace C__4_8_26
{
    public class PropertiesAM
    {   
        private string _name;
        private string _description;

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
            }
        }

        public string Description { get; set; } //auto-implemented property for Description
    }
}

// we can use getter & setter properties in C# to encapsulate the private field _name, allowing controlled access to it. The Name property provides a public interface to get and set the value of _name, while also including validation logic in the setter to ensure that the name is not null or empty. This approach promotes better encapsulation and data integrity compared to directly exposing the field.
// and also it better to use properties instead of getter and setter methods in C# because properties provide a more concise and readable syntax, making the code easier to understand and maintain. Properties also allow for additional features like data binding and serialization, which can be beneficial in certain scenarios.