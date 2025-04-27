using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

public class _3417_ZigzagTraversalTest
{
    [Theory]
    [InlineData("[[1,2],[3,4]]", new int[] { 1, 4 })]
    [InlineData("[[2,1],[2,1],[2,1]]", new int[] { 2, 1, 2 })]
    [InlineData("[[1,2,3],[4,5,6],[7,8,9]]", new int[] { 1, 3, 5, 7, 9 })]
    [InlineData("[[1,2,1,3],[5,15,7,3],[10,4,14,12]]", new int[] { 1, 1, 3, 15, 10, 14 })]
    public void ZigzagTraversal(string A, IList<int> expected)
    {
        var actual = _3417_ZigzagTraversal.ZigzagTraversal(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
