using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mcConel = CreateEmployee();
            var richter = CreateEmployee();
            Console.WriteLine("{0}=={1}={2}", mcConel.LastName, richter.LastName, mcConel.Equals(richter));
            Console.ReadKey();
        }

        static Employee CreateEmployee()
        {
            Console.WriteLine("Enter full name, birthdate, date of start of work and position in company");
            
            string firstName = Console.ReadLine();
            string middleName = Console.ReadLine();
            string lastName = Console.ReadLine();
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime startWorkDate = DateTime.Parse(Console.ReadLine());
            string position = Console.ReadLine();
            
            Employee employee = new Employee();
            try
            {
                employee = new Employee(firstName, middleName, lastName, birthDate, startWorkDate, position);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("\n{0} {1} {2}\n{3}\n{4} full years in company\n{5}",
                employee.FirstName, employee.MiddleName, employee.LastName,
                employee.Age, employee.WorkExperience, employee.Position);
            return employee;
        }
    }
}
