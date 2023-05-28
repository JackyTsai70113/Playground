using playground.Mathematics;

namespace playground.UnitTest.Mathematics;

public class IsPrimeTest
{
    [Theory]
    [InlineData(524287, true)]
    [InlineData(6700417, true)]
    [InlineData(3997649, true)]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(6, false)]
    [InlineData(7, true)]
    public void IsPrime(int number, bool expected)
    {
        var actual = new IsPrimeClass((int)(4 * 1e6)).IsPrime(number);

        Assert.Equal(expected, actual);
    }
}
