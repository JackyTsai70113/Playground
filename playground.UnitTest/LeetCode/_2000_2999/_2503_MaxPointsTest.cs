using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2503_MaxPointsTest_cs
{
    [Theory]
    [InlineData("[[1,2,3],[2,5,7],[3,5,1]]", new int[] { 5, 6, 2 }, new int[] { 5, 8, 1 })]
    [InlineData("[[1,2],[2,5],[3,5]]", new int[] { 5, 6, 2 }, new int[] { 4, 6, 1 })]
    [InlineData("[[1,2],[2,5]]", new int[] { 5, 6, 2 }, new int[] { 3, 4, 1 })]
    [InlineData("[[420766,806051,922751],[181527,815280,904568]]", new int[] { 352655, 586228, 169685, 541073, 584647, 413832, 576537, 616413 }, new int[] { 0, 2, 0, 2, 2, 0, 2, 2 })]
    [InlineData("[[420766,806051,922751],[181527,815280,904568]]", new int[] { 352655, 586228 }, new int[] { 0, 2 })]
    public void MaxPoints(string A, int[] queries, int[] expected)
    {
        var actual = _2503_MaxPoints.MaxPoints(A.To2dArr(), queries);
        Assert.Equal(expected, actual);
    }
}
