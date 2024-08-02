using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSystem
{
    internal class HourlyEmployee : Employee
    {
        public HourlyEmployee(string name, int age, string address, string nationality, int salary, int rate, string job, int workingHours, int hourRate) : base(name, age, address, nationality, salary, rate, job)
        {
            WorkingHours = workingHours;
            HourRate = hourRate;
        }

        public int WorkingHours { get; set; }
        public int HourRate { get; set; }
    }
}
