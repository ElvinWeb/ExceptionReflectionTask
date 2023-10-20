using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClasses.Exceptions
{
    public class InvalidExperienceException : Exception
    {
        public InvalidExperienceException() { }
        public InvalidExperienceException(string message) : base(message) { }
    }
}
