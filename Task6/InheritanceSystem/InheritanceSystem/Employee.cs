using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSystem
{
    internal class Employee:Person
    {
        public Employee(string name, int age, string address, string nationality,int salary, int rate, string job) : base(name,age,address,nationality)
        {
            Salary = salary;
            Rate = rate;
            Job = job;
        }

        public int Salary { get; set; }
        public int Rate { get; set; }
        public string Job { get; set; }
    }
}
