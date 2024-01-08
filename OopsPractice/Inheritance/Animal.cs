using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPractice.Inheritance
{

    public class A
    {
        public A()
        {
            Console.WriteLine("Instance class constructor");
        }
    }
    public static class B
    {
        static B()
        {
            Console.WriteLine("Static class constructor");
        }

        public static void Display()
        {
            Console.WriteLine("static method in static class");
        }
    }




}
