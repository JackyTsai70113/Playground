namespace playground.UnitTest;

public class TimeTakenTest3241
{
    [Theory]
    [InlineData("[[0,1],[0,2]]", new int[] { 2, 4, 3 })]
    [InlineData("[[0,1],[1,2]]", new int[] { 3, 2, 3 })]
    [InlineData("[[0,1]]", new int[] { 1, 2 })]
    [InlineData("[[2,4],[0,1],[2,3],[0,2]]", new int[] { 4, 6, 3, 5, 5 })]
    public void TimeTaken(string edges, int[] expected)
    {
        var actual = new TimeTaken3241().TimeTaken(edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
