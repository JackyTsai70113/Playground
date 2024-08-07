namespace playground.UnitTest;

public class MinFlipsTest3239
{
    [Theory]
    [InlineData("[[1,0,0],[0,0,0],[0,0,1]]", 2)]
    [InlineData("[[0,1],[0,1],[0,0]]", 1)]
    [InlineData("[[1],[0]]", 0)]
    public void MinFlips(string A, int expected)
    {
        var actual = MinFlips3239.MinFlips(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
