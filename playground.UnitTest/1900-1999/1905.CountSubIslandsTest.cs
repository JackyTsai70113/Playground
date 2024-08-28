namespace playground.UnitTest;

public class CountSubIslandsTest1905
{
    [Theory]
    [InlineData(
        "[[1,1,1,0,0],[0,1,1,1,1],[0,0,0,0,0],[1,0,0,0,0],[1,1,0,1,1]]",
        "[[1,1,1,0,0],[0,0,1,1,1],[0,1,0,0,0],[1,0,1,1,0],[0,1,0,1,0]]",
        3
    )]
    [InlineData(
        "[[1,0,1,0,1],[1,1,1,1,1],[0,0,0,0,0],[1,1,1,1,1],[1,0,1,0,1]]",
        "[[0,0,0,0,0],[1,1,1,1,1],[0,1,0,1,0],[0,1,0,1,0],[1,0,0,0,1]]",
        2
    )]
    public void CountSubIslands(string A1, string A2, int expected)
    {
        var actual = CountSubIslands1905.CountSubIslands(A1.To2dArr(), A2.To2dArr());
        Assert.Equal(expected, actual);
    }
}
