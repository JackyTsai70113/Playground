namespace playground.UnitTest;

public class _3102_MinimumDistanceTest
{
    [Theory]
    [InlineData("[[3,10],[5,15],[10,2],[4,4]]", 12)]
    [InlineData("[[1,1],[1,1],[1,1]]", 0)]
    [InlineData("[[9,8],[1,8],[3,1],[9,1],[7,7],[3,6]]", 13)]
    public void MinimumDistance(string points, int expected)
    {
        var actual = _3102_MinimumDistance.MinimumDistance(points.To2dArr());
        Assert.Equal(expected, actual);
    }
}
