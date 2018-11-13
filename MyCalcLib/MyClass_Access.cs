using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcLib
{
    class MyClass_Access
    {
        public byte a;
        private byte b;
        byte c;

        public MyClass_Access() { }
        public MyClass_Access(byte x, byte y, byte z)
        {
            a = x;
            b = y;
            c = z;
        }
        public void Rewrite()
        {
            Console.WriteLine("Private b = " + b);
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass_Access obj = new MyClass_Access();
            obj.a = 10;
            

            MyClass_Access obj1 = new MyClass_Access(10,5,2);
            obj1.Rewrite();
            Console.ReadLine(); 
        }
    }
}
