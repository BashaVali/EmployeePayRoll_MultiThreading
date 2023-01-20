using EmployeePayRoles_MultiThreading;

namespace EmployeePayRole_MuktiThreading
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Employee pay role program running using multi threading ");
            List<Employeecs> employee = new List<Employeecs>();
            employee.Add(new Employeecs(1, "Basha", 40000000, "Male"));
            employee.Add(new Employeecs(1, "Vali", 42535352, "Male"));
            employee.Add(new Employeecs(1, "Shaik", 30535352, "Male"));
            employee.Add(new Employeecs(1, "Aiza", 5000052, "Female"));
            employee.Add(new Employeecs(1, "Alisha", 199999, "Female"));
            //Uc1 Without Thread
            EmployeeOperation employeeOperation = new EmployeeOperation();
            DateTime starttime = DateTime.Now;
            employeeOperation.addEmployeeToPayRole(employee);
            DateTime endtime = DateTime.Now;
            Console.WriteLine("Duration without threading is " + (endtime - starttime));

            //Uc 2 with thread
            DateTime starttimeThread = DateTime.Now;
            employeeOperation.addEmployeeToPayRole_WithThread(employee);
            DateTime endtimeThread = DateTime.Now;
            Console.WriteLine("Duration with threading is " + (endtimeThread - starttimeThread));
        }
    }
}