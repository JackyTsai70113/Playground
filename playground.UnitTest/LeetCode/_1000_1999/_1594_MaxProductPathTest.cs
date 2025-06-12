using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1594_MaxProductPathTest
{
    [Theory]
    [InlineData("[[-1,-2,-3],[-2,-3,-3],[-3,-3,-2]]", -1)]
    [InlineData("[[1,-2,1],[1,-2,1],[3,-4,1]]", 8)]
    [InlineData("[[1,3],[0,-4]]", 0)]
    [InlineData("[[2,1,3,0,-3,3,-4,4,0,-4],[-4,-3,2,2,3,-3,1,-1,1,-2],[-2,0,-4,2,4,-3,-4,-1,3,4],[-1,0,1,0,-3,3,-2,-3,1,0],[0,-1,-2,0,-3,-4,0,3,-2,-2],[-4,-2,0,-1,0,-3,0,4,0,-3],[-3,-4,2,1,0,-4,2,-4,-1,-3],[3,-2,0,-4,1,0,1,-3,-1,-1],[3,-4,0,2,0,-2,2,-4,-2,4],[0,4,0,-3,-4,3,3,-1,-2,-2]]", 19215865)]
    public void MinSubarray(string A, int expected)
    {
        var actual = _1594_MaxProductPath.MaxProductPath(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
