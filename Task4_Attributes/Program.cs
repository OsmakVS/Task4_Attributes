using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass("First string", "Second string", "Third String");
            Print prt = new Print();
            prt.cPrint(testClass);
        }
    }
}
