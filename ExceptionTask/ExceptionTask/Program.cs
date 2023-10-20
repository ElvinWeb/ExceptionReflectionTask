using System.Reflection;
using TaskClasses.Exceptions;

namespace ExceptionTask
{
    internal class Program
    {
        static Employee[] employees = Array.Empty<Employee>();  
        static void Main(string[] args)
        {
            #region Try-Catch bloks
             
            try
            {

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

            Employee empolyee1 = new Employee("Samir Agayev", "HR", 19, 5, 1200);
            Employee empolyee2 = new Employee("Elvin Sarkarov", "IT", 23, 8, 1700);
            Employee empolyee3 = new Employee("Amil Amilov", "HR", 25, 10, 2000);
            AddEmployee(empolyee1);
            AddEmployee(empolyee2);
            AddEmployee(empolyee3);



            Console.WriteLine($"Sum of the employee salary:{CalculateSalary()}");

        }

        static void AddEmployee(Employee employee)
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = employee;
        }

        static int CalculateSalary()
        {
            Type employeeType = typeof(Employee);
            int sum = 0;

            BindingFlags flags = BindingFlags.NonPublic | BindingFlags.Instance;
            var salaryInfo = employeeType.GetField("_salary", flags);

            foreach(Employee employee in employees)
            {
                
                sum += Convert.ToInt32(salaryInfo.GetValue(employee));
            }

            return sum;
            
            
        }
    }
}