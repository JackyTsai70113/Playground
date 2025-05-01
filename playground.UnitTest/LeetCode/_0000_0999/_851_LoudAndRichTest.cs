using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _851_LoudAndRichTest
{
    [Theory]
    [InlineData("[[1,0],[2,1],[3,1],[3,7],[4,3],[5,3],[6,3]]", new int[] { 3, 2, 5, 4, 6, 1, 7, 0 }, new int[] { 5, 5, 2, 5, 4, 5, 6, 7 })]
    [InlineData("[]", new int[] { 0 }, new int[] { 0 })]
    public void LoudAndRich(string richer, int[] quiet, int[] expected)
    {
        var actual = _0851_LoudAndRich.LoudAndRich(richer.To2dArr(), quiet);
        Assert.Equal(expected, actual);
    }
}
