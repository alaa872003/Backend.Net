using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceSystem
{
    internal class Student : Person
    {
        public Student(string name, int age, string address, string nationality,int studentLevel, string specialization, int gPA):base(name,age,address,nationality)
        {
            StudentLevel = studentLevel;
            Specialization = specialization;
            GPA = gPA;
        }

        public int StudentLevel { get; set; }
        public string Specialization { get; set; }
        public int GPA { get; set;}
    }
}
