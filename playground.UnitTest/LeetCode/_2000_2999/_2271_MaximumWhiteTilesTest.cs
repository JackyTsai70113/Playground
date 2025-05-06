using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2271_MaximumWhiteTilesTest
{
    [Theory]
    [InlineData("[[1,5],[10,11],[12,18],[20,25],[30,32]]", 10, 9)]
    [InlineData("[[10,11],[1,1]]", 2, 2)]
    public void LargestVariance(string A, int len, int expected)
    {
        var actual = _2271_MaximumWhiteTiles.MaximumWhiteTiles(A.To2dArr(), len);
        Assert.Equal(expected, actual);
    }
}
