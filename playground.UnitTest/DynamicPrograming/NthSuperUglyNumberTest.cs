using playground.DynamicPrograming;

namespace playground.UnitTest.DynamicPrograming;

public class NthSuperUglyNumberTest
{
    [Theory]
    [InlineData(1, new int[] { 2, 3, 5 }, 1)]
    [InlineData(12, new int[] { 2, 7, 13, 19 }, 32)]
    [InlineData(5909, new int[] { 2, 3, 5, 7 }, 2143260000)]
    [InlineData(5910, new int[] { 2, 3, 5, 7 }, 2143750000)]
    [InlineData(5911, new int[] { 2, 3, 5, 7 }, 2144153025)]
    public void NthSuperUglyNumber(int n, int[] primes, int expected)
    {
        var actual = NthSuperUglyNumberClass.NthSuperUglyNumber(n, primes);
        Assert.Equal(expected, actual);
    }
}
