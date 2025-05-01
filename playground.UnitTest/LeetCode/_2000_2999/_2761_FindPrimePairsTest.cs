using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2761_FindPrimePairsTest
{
    [Theory]
    [InlineData(10, "[[3,7],[5,5]]")]
    [InlineData(2, "[]")]
    public void FindPrimePairs(int n, string expected)
    {
        var actual = _2761_FindPrimePairs.FindPrimePairs(n);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
