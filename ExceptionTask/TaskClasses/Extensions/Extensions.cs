using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClasses.Extensions
{
    public static class Extensions
    {
        public static bool IsValidFullName(string fullName)
        {
            string[] splitedStr = fullName.Trim().Split(" ");
            return splitedStr.Length == 2 && !string.IsNullOrWhiteSpace(splitedStr[0]) && !string.IsNullOrWhiteSpace(splitedStr[1]);
        }
        public static bool isValidDepartmentNo(string departmentNo)
        {
            string validDepNo = departmentNo.Trim();

            return !string.IsNullOrEmpty(validDepNo) && validDepNo.Length == 2 && char.IsUpper(validDepNo[0]) && char.IsUpper(validDepNo[1]);

        }
        public static bool isValidAge(int age)
        {
            return age > 0 && age <= 150;
        }
        public static bool IsValidExperience(int experience, int age)
        {
            return experience > 0 && age - experience <= 18;
        }
    }
}
