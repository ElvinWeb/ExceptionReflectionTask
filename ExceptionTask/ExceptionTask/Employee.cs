using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskClasses.Exceptions;
using TaskClasses.Extensions;

namespace ExceptionTask
{
    public class Employee
    {
        private static int _id;
        private int _salary;
        private string _fullName;
        private string _depNo;
        private int _age;
        private int _experience;
        public int Id { get; set; }
        public string Fullname 
        {
            get { return _fullName; }
            set
            {
                if (Extensions.IsValidFullName(value))
                {
                    _fullName = value;

                }
                else
                {
                    throw new InvalidFullNameException("Invalid full name format");
                }

            } 
        }
        public string DepartmentNo
        {
            get { return _depNo; }
            set
            {
                if (Extensions.isValidDepartmentNo(value))
                {
                    _depNo = value;
                }
                else
                {
                    throw new InvalidDepartmentNoException("Invalid departmentNo format");
                }
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (Extensions.isValidAge(value))
                {
                    _age = value;
                }
                else
                {
                    throw new InvalidAgeException("Invalid Age format");
                }

            }
        }
        public int Experience
        {
            get { return _experience; }
            set
            {
                if (Extensions.IsValidExperience(value , _age))
                {
                    _experience = value;
                }
                else
                {
                    throw new InvalidExperienceException("Invalid the experience format");
                }
            }
        }

        static Employee()
        {
            _id = 0;
        }

        public Employee(string fullname, string departmentNo, int age, int experience , int salary)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            DepartmentNo = departmentNo;
            Age = age;
            Experience = experience;
            _salary = salary;

        }
    }
}
