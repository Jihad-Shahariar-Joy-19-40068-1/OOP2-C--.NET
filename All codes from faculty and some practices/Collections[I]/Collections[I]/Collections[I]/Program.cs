using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_I_
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> cities = new List<string>(5);
            //List<string> cities = new List<string>() { "New York","Dhaka","London","Jedda","Mumbai"};
            //cities.Add("New York");
            //cities.Add("Dhaka");
            //cities.Add("London");
            //cities.Add("Jedda");
            //cities.Add("Mumbai");

            //cities.Add("New York");
            //cities.Add("Dhaka");
            //cities.Add("London");
            //cities.Add("Jedda");
            //cities.TrimExcess();
            //Console.WriteLine("Capacity: "+cities.Capacity);
            //Console.WriteLine("Count: " + cities.Count);

            //Console.WriteLine(cities[1]);
            //Console.WriteLine(cities.IndexOf("London"));
            //Console.WriteLine(cities.Contains("Dhaka"));

            //cities.Sort();
            //cities.Remove("Jedda");
            //cities.RemoveAt(2);
            //cities.Clear();
            //foreach(string item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            //List of objects

            List<Student> students = new List<Student>();
            students.Add(new Student() {Id=1001,Name="Shkib" });
            Student s2 = new Student() { Id = 2002, Name = "Tamim" };
            students.Add(s2);

            foreach (Student student in students)
            {
                Console.WriteLine("Id:" + student.Id + " Name:" + student.Name);
            }

        }
    }
}
