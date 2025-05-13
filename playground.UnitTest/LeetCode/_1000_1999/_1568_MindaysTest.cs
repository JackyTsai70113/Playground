using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1568_MindaysTest
{
    [Theory]
    [InlineData("[[0,1,0,0],[0,0,1,0],[0,0,0,0]]", 0)]
    [InlineData("[[0,1,1,0],[0,1,1,0],[0,0,0,0]]", 2)]
    [InlineData("[[1,1]]", 2)]
    [InlineData("[[1,1,0,1,1],[1,1,1,1,1],[1,1,0,1,1],[1,1,0,1,1]]", 1)]
    public void MinDays(string A, int expected)
    {
        var actual = new _1568_MinDays().MinDays(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
