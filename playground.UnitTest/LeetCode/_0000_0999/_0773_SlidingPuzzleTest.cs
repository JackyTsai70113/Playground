using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0773_SlidingPuzzleTest
{
    [Theory]
    [InlineData("[[1,2,3],[4,0,5]]", 1)]
    [InlineData("[[1,2,3],[5,4,0]]", -1)]
    [InlineData("[[4,1,2],[5,0,3]]", 5)]
    public void SlidingPuzzle(string A, int expected)
    {
        var actual = new _0773_SlidingPuzzle().SlidingPuzzle(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
