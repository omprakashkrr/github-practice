using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPractice.Constructor_Chaning
{
    class MyClass
    {
        private int MyValue;
        public MyClass()
        {

        }
        public MyClass(int value)
        {
            this.MyValue = value;
        }

        public void DisplayMyValue()
        {
            Console.WriteLine($"My Value is:{MyValue}");
        }
    }


}
