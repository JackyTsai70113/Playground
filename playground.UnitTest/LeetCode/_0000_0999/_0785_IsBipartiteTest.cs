using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0785_IsBipartiteTest
{
    [Theory]
    [InlineData("[[1,2,3],[0,2],[0,1,3],[0,2]]", false)]
    [InlineData("[[1,3],[0,2],[1,3],[0,2]]", true)]
    [InlineData("[[4],[],[4],[4],[0,2,3]]", true)]
    public void IsBipartite(string g, bool expected)
    {
        var actual = _0785_IsBipartite.IsBipartite(g.To2dArr());
        Assert.Equal(expected, actual);
    }
}
