using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Records
{
    public record MyRecordA
    {
        public int NumericValue { get; init; }
        public string StringValue { get; init; }
    }

    public record MyRecordB(
        int NumericValue,
        string StringValue
        );

    public record MyRecordC(
        int Number,
        string Name)
    {
        public string Email { get; set; }
    }
}
