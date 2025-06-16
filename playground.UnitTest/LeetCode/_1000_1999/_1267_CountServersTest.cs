using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1267_CountServersTest
{
    [Theory]
    [InlineData("[[1,0],[0,1]]", 0)]
    [InlineData("[[1,0],[1,1]]", 3)]
    [InlineData("[[1,1,0,0],[0,0,1,0],[0,0,1,0],[0,0,0,1]]", 4)]
    [InlineData("[[0,0,1,0,1],[0,1,0,1,0],[0,1,1,1,0],[1,0,0,1,1],[0,0,1,1,0]]", 12)]
    public void CountServers(string A, int expected)
    {
        var actual = _1267_CountServers.CountServers(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
