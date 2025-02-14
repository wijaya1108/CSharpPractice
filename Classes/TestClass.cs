using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Classes
{
    public class TestClass
    {
        public int NumericValue { get; set; }
        public string StringValue { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (TestClass)obj;

            return NumericValue == other.NumericValue && StringValue == other.StringValue;
        }
    }
}
