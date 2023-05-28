using playground.UnionFinds;

namespace playground.UnitTest.UnionFind;

public class CountCompleteComponentsTest
{
    [Theory]
    [InlineData(6, "[[0,1],[0,2],[1,2],[3,4],[3,5]]", 1)]
    [InlineData(6, "[[0,1],[0,2],[1,2],[3,4]]", 3)]
    [InlineData(2, "[[1,0]]", 1)]
    [InlineData(4, "[[0,1],[0,2],[1,2]]", 2)]
    [InlineData(1, "[[]]", 1)]
    public void CountCompleteComponents(int n, string edges, int expected)
    {
        var actual = CountCompleteComponentsClass.CountCompleteComponents(n, edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
