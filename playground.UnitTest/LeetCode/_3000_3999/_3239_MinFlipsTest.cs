namespace playground.UnitTest;

public class _3239_MinFlipsTest
{
    [Theory]
    [InlineData("[[1,0,0],[0,0,0],[0,0,1]]", 2)]
    [InlineData("[[0,1],[0,1],[0,0]]", 1)]
    [InlineData("[[1],[0]]", 0)]
    public void MinFlips(string A, int expected)
    {
        var actual = _3239_MinFlips.MinFlips(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
