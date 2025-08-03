using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2322_MinimumScoreTest
{
    [Theory]
    [InlineData("[1,5,5,4,11]", "[[0,1],[1,2],[1,3],[3,4]]", 9)]
    [InlineData("[5,5,2,4,4,2]", "[[0,1],[1,2],[5,2],[4,3],[1,3]]", 0)]
    [InlineData("[1,2,3]", "[[0,1],[1,2]]", 2)]
    public void MinimumScore(string numsStr, string edgesStr, int expected)
    {
        var nums = numsStr.ToArr();
        var edges = edgesStr.To2dArr();
        var actual = _2322_MinimumScore.MinimumScore(nums, edges);
        Assert.Equal(expected, actual);
    }
}
