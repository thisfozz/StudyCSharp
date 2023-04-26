using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCSharp.Classwork
{
    internal class CustomOutOfRange : Exception
    {
        public CustomOutOfRange(string message) : base(message)
        {

        }
    }
}
