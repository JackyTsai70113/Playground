namespace playground.UnitTest;

public class MinimumTimeTest3112
{
    [Theory]
    [InlineData(3, "[[0,1,2],[1,2,1],[0,2,4]]", "[1,1,5]", "[0,-1,4]")]
    [InlineData(3, "[[0,1,2],[1,2,1],[0,2,4]]", "[1,3,5]", "[0,2,3]")]
    [InlineData(2, "[[0,1,1]]", "[1,1]", "[0,-1]")]
    public void MinimumTime(int n, string edges, string disappear, string expected)
    {
        var actual = MinimumTime3112.MinimumTime(n, edges.To2dArr(), disappear.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
