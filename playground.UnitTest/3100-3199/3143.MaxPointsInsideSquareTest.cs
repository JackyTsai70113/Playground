namespace playground.UnitTest;

public class MaxPointsInsideSquareTest3143
{
    [Theory]
    [InlineData("[[2,2],[-1,-2],[-4,4],[-3,1],[3,-3]]", "abdca", 2)]
    [InlineData("[[1,1],[-2,-2],[-2,2]]", "abb", 1)]
    [InlineData("[[1,1],[-1,-1],[2,-2]]", "ccd", 0)]
    public void MaxPointsInsideSquare(string points, string s, int expected)
    {
        var actual = MaxPointsInsideSquare3143.MaxPointsInsideSquare(points.To2dArr(), s);
        Assert.Equal(expected, actual);
    }
}
