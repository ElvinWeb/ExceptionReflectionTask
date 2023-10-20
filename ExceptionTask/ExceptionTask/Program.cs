using System.Reflection;
using TaskClasses.Exceptions;

namespace ExceptionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Try-Catch bloks



            try
            {
                Employee empolyee1 = new Employee("Samir Agayev", "HR", 19, 5, 1200);
                Employee empolyee2 = new Employee("Elvin Sarkarov", "IT", 23, 8, 1700);
                Employee empolyee3 = new Employee("Amil Amilov", "HR", 25, 10, 2000);

            }
            catch (InvalidFullNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidDepartmentNoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidExperienceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion

          
            CalculateSalary();

        }

        static void CalculateSalary()
        {
            Type employeeType = typeof(Employee);
            double sum = 0;
            BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Instance;
            var myFieldInfo = employeeType.GetField("_salary", flags);
            
            
            

            
            
        }
    }
}