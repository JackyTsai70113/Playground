using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0547_FindCircleNumTest
{
    [Theory]
    [InlineData("[[1,1,0],[1,1,0],[0,0,1]]", 2)]
    public void FindCircleNum(string isConnected, int expected)
    {
        var actual = _0547_FindCircleNum.FindCircleNum(isConnected.To2dArr());
        Assert.Equal(expected, actual);
    }
}
