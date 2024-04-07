namespace playground.UnitTest;

public class CountCompleteComponentsTest2685
{
    [Theory]
    [InlineData(6, "[[0,1],[0,2],[1,2],[3,4],[3,5]]", 1)]
    [InlineData(6, "[[0,1],[0,2],[1,2],[3,4]]", 3)]
    [InlineData(4, "[[1,2],[1,0],[3,1]]", 0)]
    [InlineData(2, "[[1,0]]", 1)]
    [InlineData(4, "[[0,1],[0,2],[1,2]]", 2)]
    public void CountCompleteComponents(int n, string edges, int expected)
    {
        var actual = CountCompleteComponents2685.CountCompleteComponents(n, edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
