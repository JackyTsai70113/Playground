namespace playground.UnitTest;

public class ValidPathTest1971
{
    [Theory]
    [InlineData(3, "[[0,1],[1,2],[2,0]]", 0, 2, true)]
    [InlineData(6, "[[0,1],[0,2],[3,5],[5,4],[4,3]]", 0, 5, false)]
    public void ValidPath(int n, string edges, int source, int destination, bool expected)
    {
        var actual = ValidPath1971.ValidPath(n, edges.To2dArr(), source, destination);
        Assert.Equal(expected, actual);
    }
}
