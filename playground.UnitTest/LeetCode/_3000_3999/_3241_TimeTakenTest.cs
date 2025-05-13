namespace playground.UnitTest.LeetCode._3000_3999;

public class _3241_TimeTakenTest
{
    [Theory]
    [InlineData("[[0,1],[0,2]]", new int[] { 2, 4, 3 })]
    [InlineData("[[0,1],[1,2]]", new int[] { 3, 2, 3 })]
    [InlineData("[[0,1]]", new int[] { 1, 2 })]
    [InlineData("[[2,4],[0,1],[2,3],[0,2]]", new int[] { 4, 6, 3, 5, 5 })]
    [InlineData("[[5,4],[2,1],[4,2],[1,0],[3,1]]", new int[] { 6, 5, 3, 6, 5, 7 })]
    public void TimeTaken(string edges, int[] expected)
    {
        var actual = _3241_TimeTaken.TimeTaken(edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
