﻿using System;
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
    }
}