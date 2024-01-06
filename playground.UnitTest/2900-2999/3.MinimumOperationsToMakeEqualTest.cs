namespace playground.UnitTest;

public class MinimumOperationsToMakeEqualTest
{
    [Theory]
    [InlineData(26, 1, 3)]
    [InlineData(54, 2, 4)]
    [InlineData(25, 30, 5)]
    public void MinimumOperationsToMakeEqual(int x, int y, int expected)
    {
        var actual = MinimumOperationsToMakeEqual29.MinimumOperationsToMakeEqual(x, y);
        Assert.Equal(expected, actual);
    }
}
