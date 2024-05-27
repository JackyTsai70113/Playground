namespace playground.UnitTest;

public class MinCostConnectPointsTest1584
{
    [Theory]
    [InlineData("[[0,0],[2,2],[3,10],[5,2],[7,0]]", 20)]
    [InlineData("[[0,0],[2,2],[3,10],[5,2]]", 16)]
    [InlineData("[[0,0],[2,2],[3,10]]", 13)]
    [InlineData("[[3,12],[-2,5],[-4,1]]", 18)]
    public void MinCostConnectPoints(string A, int expected)
    {
        var actual = MinCostConnectPoints1584.MinCostConnectPoints(A.To2dArr());
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[[0,0],[2,2],[3,10],[5,2],[7,0]]", 20)]
    [InlineData("[[0,0],[2,2],[3,10],[5,2]]", 16)]
    [InlineData("[[0,0],[2,2],[3,10]]", 13)]
    [InlineData("[[3,12],[-2,5],[-4,1]]", 18)]
    public void MinCostConnectPoints2(string A, int expected)
    {
        var actual = MinCostConnectPoints1584.MinCostConnectPoints2(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
