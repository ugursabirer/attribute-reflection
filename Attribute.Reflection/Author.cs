using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute.Reflection
{
    [System.AttributeUsage(System.AttributeTargets.Class | 
        System.AttributeTargets.Struct, 
        AllowMultiple = true)]
    public class Author : System.Attribute
    {
        private string Name { get; set; }

        public double Version { get; set; }

        public Author(string name)
        {
            this.Name = name;

            // default
            Version = 1.0;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
