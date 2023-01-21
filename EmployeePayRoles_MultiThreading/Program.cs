using EmployeePayRoles_MultiThreading;

namespace EmployeePayRole_MuktiThreading
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Employee pay role program running using multi threading ");
            Console.WriteLine("Hint 1.Display data without thread 2.DisplayData with thread 3. Add data without threa 4.Add data with Thread");
            List<Employeecs> employee = new List<Employeecs>();
            EmployeeOperation employeeOperation = new EmployeeOperation();
            employee.Add(new Employeecs(1, "Basha", 40000000, "Male"));
            employee.Add(new Employeecs(1, "Vali", 42535352, "Male"));
            employee.Add(new Employeecs(1, "Shaik", 30535352, "Male"));
            employee.Add(new Employeecs(1, "Aiza", 5000052, "Female"));
            employee.Add(new Employeecs(1, "Alisha", 199999, "Female"));

            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    ////Uc1 Without Thread
                    DateTime starttime = DateTime.Now;
                    employeeOperation.addEmployeeToPayRole(employee);
                    DateTime endtime = DateTime.Now;
                    Console.WriteLine("Duration without threading is " + (endtime - starttime));
                    break;
                case 2:
                    ////Uc 2 with thread
                    DateTime starttimeThread = DateTime.Now;
                    employeeOperation.addEmployeeToPayRole_WithThread(employee);
                    DateTime endtimeThread = DateTime.Now;
                    Console.WriteLine("Duration with threading is " + (endtimeThread - starttimeThread));
                    break;
                case 3:
                    ////Uc3 Without Thread
                    DateTime starttimeADD = DateTime.Now;
                    employeeOperation.SingleAddEmployee(employee);
                    DateTime endtimeADD = DateTime.Now;
                    Console.WriteLine("Duration without threading is " + (endtimeADD - starttimeADD));
                    break;
                case 4:
                    Console.WriteLine("Enter data for Threading");
                    //// Uc 3 with thread
                    DateTime starttimeThreadADD = DateTime.Now;
                    employeeOperation.SingleAddEmployee_WithThread(employee);
                    DateTime endtimeThreadADD = DateTime.Now;
                    Console.WriteLine("Duration with threading is " + (endtimeThreadADD - starttimeThreadADD));
                    break;
            }
        }
    }
}