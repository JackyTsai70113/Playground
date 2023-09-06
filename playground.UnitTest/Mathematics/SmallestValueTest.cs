using playground.Mathematics;

namespace playground.UnitTest.Mathematics;

public class SmallestValueTest
{
    [Theory]
    [InlineData(15, 5)]
    [InlineData(3, 3)]
    public void SmallestValue(int n, int expected)
    {
        var actual = SmallestValueClass.SmallestValue(n);
        Assert.Equal(expected, actual);
    }
}
