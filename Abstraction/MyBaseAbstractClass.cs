using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Abstraction
{
    public abstract class MyBaseAbstractClass
    {
        public void Print()
        {
            Console.WriteLine("Non-abstract method");
        }

        public abstract void PrintAbstract();
    }

    public class MyNormalClass : MyBaseAbstractClass
    {
        public override void PrintAbstract()
        {
            Console.WriteLine("Newly implemented Abstract method");
        }
    }

    public interface ICheckAbstract
    {
        void PrintInterface();
    }

    public abstract class NewAbstractClass : MyBaseAbstractClass, ICheckAbstract
    {
        public void PrintInterface()
        {
            Console.WriteLine("Method from the interface");
        }
    }

    public class NewNormalClass : NewAbstractClass
    {
        public override void PrintAbstract()
        {
            Console.WriteLine("Newly implemented Abstract method");
        }
    }
}
