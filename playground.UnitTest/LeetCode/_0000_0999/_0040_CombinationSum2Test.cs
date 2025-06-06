using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0040_CombinationSum2Test
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 1 }, 2, "[[1,1]]")]
    [InlineData(new int[] { 1, 1, 1, 1 }, 3, "[[1,1,1]]")]
    [InlineData(new int[] { 1, 1, 1, 1 }, 4, "[[1,1,1,1]]")]
    [InlineData(new int[] { 1, 2, 2, }, 5, "[[1,2,2]]")]
    [InlineData(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8, "[[1,1,6],[1,2,5],[1,7],[2,6]]")]
    [InlineData(new int[] { 2, 5, 2, 1, 2 }, 5, "[[1,2,2],[5]]")]
    public void CombinationSum(int[] A, int target, string expected)
    {
        var actual = _0040_CombinationSum2.CombinationSum2(A, target);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
