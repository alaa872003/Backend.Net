using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSystem
{
    internal class SalariedEmployee : Employee
    {
        public SalariedEmployee(string name, int age, string address, string nationality, int salary, int rate, string job, int bonus, int deductions) : base(name,age,address,nationality,salary,rate,job)
        {
            Bonus = bonus;
            Deductions = deductions;
        }

        public int Bonus { get; set;}
        public int Deductions { get; set;}
    }
}
