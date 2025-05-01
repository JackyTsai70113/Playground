using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0354_MaxEnvelopesTest
{
    [Theory]
    [InlineData("[[5,4],[6,4],[6,7],[2,3]]", 3)]
    [InlineData("[[5,4],[6,1],[6,7],[2,3]]", 3)]
    [InlineData("[[5,4],[7,2],[8,3],[9,4],[6,1],[6,7],[2,3]]", 4)]
    [InlineData("[[4,5],[4,6],[6,7],[2,3],[1,1]]", 4)]
    [InlineData("[[1,1],[1,1],[1,1]]", 1)]
    public void MaxEnvelopes(string A, int expected)
    {
        var actual = _0354_MaxEnvelopes.MaxEnvelopes(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
