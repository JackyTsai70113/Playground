using playground._2700_2799;

namespace playground.UnitTest._2700_2799;

public class _2749_MakeTheIntegerZeroTest
{
    [Theory]
    [InlineData(3, -2, 3)]
    [InlineData(5, 7, -1)]
    [InlineData(1000000000, 0, 13)]
    [InlineData(1000000000, 1000000000, -1)]
    [InlineData(112577768, -501662198, 16)]
    public void MakeTheIntegerZero(int num1, int num2, int expected)
    {
        var actual = _2749_MakeTheIntegerZero.MakeTheIntegerZero(num1, num2);
        Assert.Equal(expected, actual);
    }
}
