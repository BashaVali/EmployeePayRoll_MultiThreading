using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoles_MultiThreading
{
    public class EmployeeOperation
    {
        public List<Employeecs> employee = new List<Employeecs>();
        /// <summary>
        /// Uc1 Without Use of Thread
        /// </summary>
        public void addEmployeeToPayRole(List<Employeecs> employeeList)
        {
            foreach (var emp in employeeList)
            {
                Console.WriteLine(" Employee being added " + emp.Name);
                this.addEmployeeToPayRole(emp);
                Console.WriteLine("Employee added " + emp.Name);
            }
        }

        public void addEmployeeToPayRole(Employeecs emp)
        {
            employee.Add(emp);
        }
        /// <summary>
        /// Uc 2 With Thread
        /// </summary>
        /// <param name="employeeList"></param>
        public void addEmployeeToPayRole_WithThread(List<Employeecs> employeeList)
        {
            foreach (var emp in employeeList)
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine(" Employee being added " + emp.Name);
                    this.addEmployeeToPayRole(emp);
                    Console.WriteLine("Employee added " + emp.Name);
                });
                thread.Start();
            }
            Console.WriteLine(this.employee.Count);
        }
        /// <summary>
        /// UC3 added data for single Employee Without Threading
        /// </summary>
        /// <param name="employeeList"></param>
        public void SingleAddEmployee(List<Employeecs> employeeList)
        {
            Console.WriteLine("Enter the Id");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the firstName");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            long Salary = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Gender");
            String Gendr = Console.ReadLine();

            Employeecs employeecs = new Employeecs(Id, Name, Salary, Gendr);
            Console.WriteLine(" Employee being added " + Name);
            Console.WriteLine("id being added" + Id);
            Console.WriteLine("Salary being added" + Salary);
            Console.WriteLine("Gender being added" + Gendr);
            employeeList.Add(employeecs);
            Console.WriteLine("Employee added " + Name);
            Console.WriteLine("id added" + Id);
            Console.WriteLine("Salary added" + Salary);
            Console.WriteLine("Gender added" + Gendr);
        }
        /// <summary>
        /// UC3 added data for single Employee Without Threading
        /// </summary>
        /// <param name="employeeList"></param>
        public void SingleAddEmployee_WithThread(List<Employeecs> employeeList)
        {
            Console.WriteLine("Enter the Id");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the firstName");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            long Salary = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Gender");
            String Gendr = Console.ReadLine();
            // Task is Use for parallel
            Task task = new Task(() =>
            {
                Employeecs employeecs = new Employeecs(Id, Name, Salary, Gendr);
                Console.WriteLine(" Employee being added " + Name);
                Console.WriteLine("id being added" + Id);
                Console.WriteLine("Salary being added" + Salary);
                Console.WriteLine("Gender being added" + Gendr);
                employeeList.Add(employeecs);
                Console.WriteLine("Employee added " + Name);
                Console.WriteLine("id added" + Id);
                Console.WriteLine("Salary added" + Salary);
                Console.WriteLine("Gender added" + Gendr);
            });

        }
    }
}