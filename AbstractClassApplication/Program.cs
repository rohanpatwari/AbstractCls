using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassApplication
{

    public abstract class abClass
    {
        public int AddtwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        public abstract int MultwoNumbers(int n1, int n2);
    }
    class DerivedCls : abClass
    {
        public override int MultwoNumbers(int n1, int n2)
        {
            return n1 * n2;
        }
        static void Main(string[] args)
        {
            DerivedCls d = new DerivedCls();
            int added = d.AddtwoNumbers(4, 5);
            int multiply = d.MultwoNumbers(6, 7);
            Console.WriteLine("added: {0} and multiplied: {1}", added, multiply);
            Console.ReadLine();
        }
    }
}
