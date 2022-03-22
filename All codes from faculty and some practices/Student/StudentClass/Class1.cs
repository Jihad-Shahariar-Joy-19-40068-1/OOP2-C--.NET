using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class StudentClass
    {
        public string name, id, semester;
        public double cgpa;
        public void InitVal(string n, string id, string sem, double cgpa)
        {
            this.name = n;
            this.id = id;
            this.semester = sem;
            this.cgpa = cgpa;
        }
        public void PrintStudentInfo()
        {
            System.Console.WriteLine("\nStudent Info: ");
            System.Console.WriteLine("\nName: " + name);
            System.Console.WriteLine("\nID: " + id);
            System.Console.WriteLine("\nSemester: " + semester);
            System.Console.WriteLine("\nCGPA: " + cgpa);
        }
    }
}
