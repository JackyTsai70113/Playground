using playground.PriorityQueues;

namespace playground.UnitTest.PriorityQueue;

public class MinimumEffortPathTest
{
    [Theory]
    [InlineData("[[1,2,2],[3,8,2],[5,3,5]]", 2)]
    [InlineData("[[1,2,3],[3,8,4],[5,3,5]]", 1)]
    [InlineData("[[1,2,1,1,1],[1,2,1,2,1],[1,2,1,2,1],[1,2,1,2,1],[1,1,1,2,1]]", 0)]
    public void MinimumEffortPath(string A, int expected)
    {
        var actual = MinimumEffortPathClass.MinimumEffortPath(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
