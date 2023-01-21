using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoles_MultiThreading
{
    public class Employeecs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Salary { get; set; }
        public string Gender { get; set; }
        public Employeecs(int id, string name, long salary, string gender)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Gender = gender;
        }
    }
}