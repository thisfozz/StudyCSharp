using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Classwork
{
    internal class CustomInvalidException : Exception
    {
        public CustomInvalidException(string message) : base(message) { }

        public string Value { get; set; }
    }
}
