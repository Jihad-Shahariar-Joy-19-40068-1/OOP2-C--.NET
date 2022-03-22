using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_I_
{
    interface ISleepable
    {
        //int x = 10;//Error
        void Sleep();
        void Work();
    }

    interface IRunnable
    {
        void Run();
        void Work();
    }

    class Animal
    {
        virtual public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }
    
    class Dog:Animal,ISleepable,IRunnable
    {
        public void Sleep()
        {
            Console.WriteLine("Dog is sleeping.");
        }
        public void Run()
        {
            Console.WriteLine("Dog is running.");
        }
        override public void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }
        //public void Work()
        //{
        //    Console.WriteLine("Dog is working.");
        //}

        //Explicit interface implementation

        void ISleepable.Work()
        {
            Console.WriteLine("Dog is working->ISleepable");
        }
        void IRunnable.Work()
        {
            Console.WriteLine("Dog is working->IRunnable");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ISleepable sleepable = new ISleepable();//Error
            ISleepable sleepable = new Dog();
            //sleepable.Sleep();
            //IRunnable runnable =(IRunnable) sleepable;
            //runnable.Run();
            //((IRunnable)sleepable).Run();
            //((Dog)sleepable).Eat();
            //((Dog)sleepable).Work();
            ((IRunnable)sleepable).Work();
        }
    }
}
