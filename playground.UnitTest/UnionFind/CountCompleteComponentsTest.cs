using playground.UnionFinds;
using playground.UnitTest.Utils;

namespace playground.UnitTest.UnionFind;

public class CountCompleteComponentsTest
{
    [Theory]
    [InlineData(6, "[[0,1],[0,2],[1,2],[3,4],[3,5]]", 1)]
    [InlineData(6, "[[0,1],[0,2],[1,2],[3,4]]", 3)]
    [InlineData(2, "[[1,0]]", 1)]
    [InlineData(4, "[[0,1],[0,2],[1,2]]", 2)]
    public void CountCompleteComponents(int n, string g, int expected)
    {
        var actual = CountCompleteComponentsClass.CountCompleteComponents(n, g.To2dArr<int>());
        Assert.Equal(actual, expected);
    }
}
