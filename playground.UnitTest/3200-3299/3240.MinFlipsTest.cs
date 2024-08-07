namespace playground.UnitTest;

public class MinFlipsTest3240
{
    [Theory]
    [InlineData("[[1,0,0],[0,1,0],[0,0,1]]", 3)]
    [InlineData("[[0,0,1],[1,1,1]]", 2)]
    [InlineData("[[0,1],[0,1],[0,0]]", 2)]
    [InlineData("[[1],[1]]", 2)]
    public void MinFlips(string A, int expected)
    {
        var actual = MinFlips3240.MinFlips(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
