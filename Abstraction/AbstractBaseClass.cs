using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Abstraction
{
    public abstract class AbstractBaseClass
    {
        protected void ProtectedPrintInBaseClass()
        {
            Console.WriteLine("ProtectedPrintInBaseClass");
        }

        protected abstract void ProtectedAbstractPrint();
    }

    public class DerivedClass : AbstractBaseClass
    {
        public void PrintInDerivedClass()
        {
            Console.WriteLine("We are in the derived class");
            ProtectedPrintInBaseClass();
            Console.WriteLine("We are leaving the method in the derived class");
        }

        protected override void ProtectedAbstractPrint()
        {
            Console.WriteLine("ProtectedAbstractPrint");
        }
    }
}
