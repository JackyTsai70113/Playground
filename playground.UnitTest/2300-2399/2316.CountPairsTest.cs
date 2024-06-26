namespace playground.UnitTest;

public class CountPairsTest2316
{
    [Theory]
    [InlineData(3, "[[0, 1], [0, 2], [1, 2]]", 0)]
    [InlineData(7, "[[0, 2], [0, 5], [2, 4], [1, 6], [5, 4]]", 14)]
    public void CountPairs(int n, string edges, int expected)
    {
        var actual = CountPairs2316.CountPairs(n, edges.To2dArr());
        Assert.Equal(expected, actual);
    }
}
