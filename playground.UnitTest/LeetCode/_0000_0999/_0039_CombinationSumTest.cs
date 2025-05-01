using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0039_CombinationSumTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 6, 7 }, 7, "[[2,2,3],[7]]")]
    [InlineData(new int[] { 2, 3, 5 }, 8, "[[2,2,2,2],[2,3,3],[3,5]]")]
    [InlineData(new int[] { 2 }, 1, "[]")]
    public void CombinationSum(int[] A, int target, string expected)
    {
        var actual = _0039_CombinationSum.CombinationSum(A, target);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
