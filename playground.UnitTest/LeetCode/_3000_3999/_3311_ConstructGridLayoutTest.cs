using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3311_ConstructGridLayoutTest
{
    [Theory]
    [InlineData(4, "[[0,1],[0,2],[1,3],[2,3]]", "[[0,1],[2,3]]")]
    [InlineData(5, "[[0,1],[1,3],[2,3],[2,4]]", "[[0,1,3,2,4]]")]
    [InlineData(9, "[[0,1],[0,4],[0,5],[1,7],[2,3],[2,4],[2,5],[3,6],[4,6],[4,7],[6,8],[7,8]]", "[[1, 0, 5], [7, 4, 2], [8, 6, 3]]")]
    public void RemainingMethods(int n, string A, string expected)
    {
        var actual = _3311_ConstructGridLayout.ConstructGridLayout(n, A.To2dArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}