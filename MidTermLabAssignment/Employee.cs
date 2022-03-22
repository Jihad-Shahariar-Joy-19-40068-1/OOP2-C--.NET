using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment
{
    class Employee
    {
        private string id, name, address;
        private Player player;
        private Manager manager;
        

        //Field declaration
        public Employee(string id, string name, string address,Player player)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.player=player;
        }
        public Employee(Manager manager)
        { this.manager = manager; }

        public Employee(string id, string name, string address, Manager manager)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.manager = manager;
        }

        //Property declaration
        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public string Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public Player Player
        {
            set { this.player = value; }
            get { return this.player; }
        }
        public Manager Manager
        {
            set { this.manager = value; }
            get { return this.manager; }
        }
        //Method declaration
        public void PrintInfo()
        {
            Console.WriteLine("Information: \nID: {0}\nName: {1}\nAddress: {2}", this.Id, this.Name, this.Address);
            Console.WriteLine(player.GetPlayer());//add more info from player class
            Console.WriteLine(player.GetTotalEarn());
            Console.WriteLine("Eligibility: " + player.GetPlayerStatus());
            Console.WriteLine("Skill: " + player.GetSkilledPlayers());
            Console.WriteLine("==============================================");
            
        }
        public void EmployeeStatus()
        {
            //////////////////////////////   
        }

        public void PrintInfo2()
        {
            Console.WriteLine("Information: \nID: {0}\nName: {1}\nAddress: {2}", this.Id, this.Name, this.Address);
            Console.WriteLine(Manager.GetManager());//add more info from managerr class
            Console.WriteLine("Eligibility: " + manager.GetManagerStatus());
            Console.WriteLine("==============================================");

        }
        


    }
}

