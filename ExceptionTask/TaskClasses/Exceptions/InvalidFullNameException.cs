using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClasses.Exceptions
{
    public class InvalidFullNameException : Exception
    {
        public InvalidFullNameException() { }
        public InvalidFullNameException(string message) : base(message) { }
    }
}
