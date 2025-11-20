namespace TestProject1;

using System.Collections;
using Xunit;
public class TriangleArea : IEnumerable<object[]>
{
         public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 10, 4, 20 };
        yield return new object[] { 6, 5, 15 };
        yield return new object[] { 8, 3, 12 };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

