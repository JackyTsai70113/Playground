namespace playground.UnitTest;

public class NetworkDelayTimeTest0743
{
    [Theory]
    [InlineData("[[2,1,1],[2,3,1],[3,4,1]]", 4, 2, 2)]
    [InlineData("[[1,2,1]]", 2, 1, 1)]
    [InlineData("[[1,2,1]]", 2, 2, -1)]
    [InlineData("[[1,2,1],[2,3,2],[1,3,2]]", 3, 1, 2)]
    public void NetworkDelayTime(string times, int n, int k, int expected)
    {
        var actual = NetworkDelayTime0743.NetworkDelayTime(times.To2dArr(), n, k);
        Assert.Equal(expected, actual);
    }
}
