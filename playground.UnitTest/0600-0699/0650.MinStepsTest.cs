namespace playground.UnitTest;

public class MinStepsTest0650
{
    [Theory]
    [InlineData(1, 0)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(6, 5)]
    [InlineData(7, 7)]
    [InlineData(8, 6)]
    [InlineData(9, 6)]
    [InlineData(1000, 21)]
    public void MinSteps(int n, int expected)
    {
        var actual = MinSteps0650.MinSteps(n);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(6, 5)]
    [InlineData(7, 7)]
    [InlineData(8, 6)]
    [InlineData(9, 6)]
    [InlineData(1000, 21)]
    public void MinSteps2(int n, int expected)
    {
        var actual = MinSteps0650.MinSteps2(n);
        Assert.Equal(expected, actual);
    }
}
