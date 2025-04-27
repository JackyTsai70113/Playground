namespace playground.UnitTest;

public class ClimbStairsTest0070
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(10, 89)]
    [InlineData(45, 1836311903)]
    public void ClimbStairs(int n, int expected)
    {
        var actual = ClimbStairs0070.ClimbStairs(n);
        Assert.Equal(expected, actual);
    }
}
