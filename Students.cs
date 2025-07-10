using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopwithui
{
    internal class Students
    {
        public string Student;
        public string Section; 
        public int Year;
        public int Month;
        public int Day;
        public Students(string student, string section, int day, int month, int year)
        {
            Student = student;
            Section = section;
            Day = day;
            Year = year;
            Month = month;
        }
    }
}
