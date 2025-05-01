namespace playground.UnitTest;

public class _3111_MinRectanglesToCoverPointsTest
{
    [Theory]
    [InlineData("[[2,1],[1,0],[1,4],[1,8],[3,5],[4,6]]", 1, 2)]
    [InlineData("[[0,0],[1,1],[2,2],[3,3],[4,4],[5,5],[6,6]]", 2, 3)]
    [InlineData("[[2,3],[1,2]]", 0, 2)]
    public void MinRectanglesToCoverPoints(string A, int w, int expected)
    {
        var actual = _3111_MinRectanglesToCoverPoints.MinRectanglesToCoverPoints(A.To2dArr(), w);
        Assert.Equal(expected, actual);
    }
}
