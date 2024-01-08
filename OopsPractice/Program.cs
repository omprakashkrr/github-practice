using OopsPractice.Constructor_Chaning;
using System;

namespace OopsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.DisplayMyValue();
            MyClass myClass2 = new MyClass(10);
            myClass2.DisplayMyValue();
            myClass2.DisplayMyValue();
            Console.ReadKey();

        }
    }
}
