using playground.BitManipulation;

namespace playground.UnitTest.BitManipulation;

public class MakeTheIntegerZeroTest
{
    [Theory]
    [InlineData(3, -2, 3)]
    [InlineData(5, 7, -1)]
    [InlineData(1000000000, 0, 13)]
    [InlineData(1000000000, 1000000000, -1)]
    public void MakeTheIntegerZero(int num1, int num2, int expected)
    {
        var actual = MakeTheIntegerZeroClass.MakeTheIntegerZero(num1, num2);
        Assert.Equal(expected, actual);
    }
}
