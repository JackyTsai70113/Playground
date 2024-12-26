using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

public class _3393_CheckValidCutsTest
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
