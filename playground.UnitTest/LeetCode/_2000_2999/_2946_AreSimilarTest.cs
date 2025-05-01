using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2946_AreSimilarTest
{
    [Theory]
    [InlineData("[[1,2,1,2],[5,5,5,5],[6,3,6,3]]", 2, true)]
    [InlineData("[[1,2,1,3],[5,5,5,5],[6,3,6,3]]", 2, false)]
    [InlineData("[[2,2],[2,2]]", 3, true)]
    [InlineData("[[1,2]]", 1, false)]
    public void AreSimilar(string A, int k, bool expected)
    {
        var actual = _2946_AreSimilar.AreSimilar(A.To2dArr(), k);
        Assert.Equal(expected, actual);
    }
}
