using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3394_CheckValidCutsTest
{
    [Theory]
    [InlineData(5, "[[1,0,5,2],[0,2,2,4],[3,2,5,3],[0,4,4,5]]", true)]
    [InlineData(4, "[[0,0,1,1],[2,0,3,4],[0,2,2,3],[3,0,4,3]]", true)]
    [InlineData(4, "[[0,2,2,4],[1,0,3,2],[2,2,3,4],[3,0,4,2],[3,2,4,4]]", false)]
    [InlineData(4, "[[0,0,1,4],[1,0,2,3],[2,0,3,3],[3,0,4,3],[1,3,4,4]]", false)]
    public void CountPathsWithXorValue(int n, string A, bool expected)
    {
        var actual = _3394_CheckValidCuts.CheckValidCuts(n, A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
