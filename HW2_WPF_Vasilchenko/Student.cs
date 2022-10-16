using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_WPF_Vasilchenko
{
    internal class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public int grade { get; set; }


        public Student(string _fName, string _lName, int _grade, int _age)
        {
            firstName = _fName;
            lastName = _lName;
            age = _age;
            grade = _grade;
        }
    }


     
}
