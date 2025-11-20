using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class MemberData
    {
        public static IEnumerable<object[]> Data =>
           new List<object[]>
           {
                new object[] { 3, 4, 5 },
                new object[] { 6, 8, 10 },
                new object[] { 5, 12, 13 }
           };
    }
}
