using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentClass st1 = new StudentClass();
            System.Console.Write("Enter Your Name: ");
            st1.name = System.Console.ReadLine();
            System.Console.Write("Enter Your ID: ");
            st1.id = System.Console.ReadLine();
            System.Console.Write("Enter Your Semester: ");
            st1.semester = System.Console.ReadLine();
            System.Console.Write("Enter Your CGPA: ");
            st1.cgpa = System.Convert.ToDouble(System.Console.ReadLine());
            st1.InitVal(st1.name, st1.id, st1.semester, st1.cgpa);
            st1.PrintStudentInfo();
            System.Console.ReadKey();

        }
    }
}
