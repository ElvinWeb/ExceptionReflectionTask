using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClasses.Exceptions
{
    public class InvalidDepartmentNoException : Exception
    {
        public InvalidDepartmentNoException() { }
        public InvalidDepartmentNoException(string message) : base(message) { }
    }
}
