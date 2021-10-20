using Prb.Methods.Sum.Cons;
using System;
using Xunit;

namespace Prb.Methods.Sum.Test
{
    public class SumTests
    {
        [Fact]
        public void Test1()
        {
            int a = 5;
            int b = 3;

            int sum = new Runner().Sum(a,b);

            Assert.Equal(8, sum);
        }
    }
}
