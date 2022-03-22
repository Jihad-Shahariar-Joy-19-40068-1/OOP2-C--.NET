using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_I_
{
    //Delegate
    public delegate void MyDelegate(int x,int y);
    public delegate void MethodPass();
    class Test
    {
        public void F1()
        {
            Console.WriteLine("F1 Method");
        }
        public void F2()
        {
            Console.WriteLine("F2 Method");
            MethodPass methodPass = F1;
            Show(F1);
        }
        public void Show(MethodPass pass)
        {
            pass();
        }
    }
    class Calculator
    {
        public static void Addition(int a,int b)
        {
            Console.WriteLine("Addition Result: "+(a+b));
        }
        public static void Substraction(int a, int b)
        {
            Console.WriteLine("Substraction Result: " + (a - b));
        }
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication Result: " + (a * b));
        }
        public static void Division(int a, int b)
        {
            if(b==0)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            else
            Console.WriteLine("Division Result: " + (a / b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = new MyDelegate(Calculator.Addition);
            //MyDelegate myDelegate = Calculator.Addition;
            //myDelegate.Invoke(10,20);
            //myDelegate(10, 20);
            //myDelegate -= Calculator.Substraction;
            //myDelegate += Calculator.Multiplication;
            //myDelegate += Calculator.Division;
            //myDelegate -= Calculator.Addition;
            //myDelegate += Calculator.Substraction;
            //myDelegate -= Calculator.Substraction;
            //myDelegate += Calculator.Substraction;
            //myDelegate(20, 10);

            //MyDelegate md1 = Calculator.Addition;
            //MyDelegate md2 = Calculator.Substraction;
            //MyDelegate md3 = Calculator.Multiplication;
            //MyDelegate md4 = Calculator.Division;
            //Multicast delegate
            //MyDelegate myDelegate = md1 + md2 + md3 + md4;
            //myDelegate(20, 10);

            Test test = new Test();
            test.F2();
        }
    }
}
