using EmployeePayRoles_MultiThreading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeePayRole_MultiThreadingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Employee pay role program running using multi threading ");
            List<Employeecs> employee = new List<Employeecs>();
            employee.Add(new Employeecs(1, "Basha", 40000000, "Male"));
            employee.Add(new Employeecs(1, "Vali", 42535352, "Male"));
            employee.Add(new Employeecs(1, "Shaik", 30535352, "Male"));
            employee.Add(new Employeecs(1, "Aiza", 5000052, "Female"));
            employee.Add(new Employeecs(1, "Alisha", 199999, "Female"));

            EmployeeOperation employeeOperation = new EmployeeOperation();
            DateTime starttime = DateTime.Now;
            employeeOperation.addEmployeeToPayRole(employee);
            DateTime endtime = DateTime.Now;
            Console.WriteLine("Duration without threading is " + (endtime - starttime));
        }
    }
}