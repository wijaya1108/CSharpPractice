using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Abstraction
{
    public class BaseClass2
    {
        protected void PrintInBaseClass()
        {
            Console.WriteLine("PrintInBaseClass");
        }

        public virtual void VirtualPrintInBaseClass()
        {
            Console.WriteLine("VirtualPrintInBaseClass");
        }
    }

    public class DerivedClass2 : BaseClass2
    {
        public void PrintInDerivedClass()
        {
            Console.WriteLine("We are in the derived class");
            PrintInBaseClass();
        }

        public override void VirtualPrintInBaseClass()
        {
            Console.WriteLine("VirtualPrintInBaseClass in derived class");
            Console.WriteLine("And now we are calling the VirtualPrintInBaseClass in base class....");
            base.VirtualPrintInBaseClass();
        }
    }
}
