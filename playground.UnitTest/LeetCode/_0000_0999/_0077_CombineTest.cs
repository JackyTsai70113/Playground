using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0077_CombineTest
{
    [Theory]
    [InlineData(4, 2, "[[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]")]
    [InlineData(1, 1, "[[1]]")]
    public void CombineTest(int n, int k, string expected)
    {
        var actual = _0077_Combine.Combine(n, k);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
