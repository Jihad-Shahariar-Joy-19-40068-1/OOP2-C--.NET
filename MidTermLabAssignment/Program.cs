using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("PL-001", "Jihad Shahariar Joy", "Barisal", new Player(90, 1000, 15));
            employee.PrintInfo();
            employee.EmployeeStatus();

            Employee employee2 = new Employee("M-01", "Jihad Shahariar ", "Betagi", new Manager(80, 1000, 25, 3));
            employee2.PrintInfo2();
            employee2.EmployeeStatus();

            //Player player = new Player(90, 1000, 15);
            //player.PrintPlayerInfo();

            //Manager manager = new Manager(80, 1000, 30, 3);
            //manager.PrintManagerInfo();
        }
    }
}
