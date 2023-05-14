using playground.DynamicPrograming;
using playground.UnitTest.Utils;

namespace playground.UnitTest.DynamicPrograming;

public class NthSuperUglyNumberTest
{
    [Theory]
    [InlineData(1, "[2,3,5]", 1)]
    [InlineData(12, "[2,7,13,19]", 32)]
    [InlineData(5909, "[2,3,5,7]", 2143260000)]
    [InlineData(5910, "[2,3,5,7]", 2143750000)]
    [InlineData(5911, "[2,3,5,7]", 2144153025)]
    public void NthSuperUglyNumber(int n, string primesStr, int expected)
    {
        var primes = primesStr.ToArr<int>();
        var actual = NthSuperUglyNumberClass.NthSuperUglyNumber(n, primes);
        Assert.Equal(expected, actual);
    }
}
