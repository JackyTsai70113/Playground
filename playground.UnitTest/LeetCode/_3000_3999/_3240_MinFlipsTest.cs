namespace playground.UnitTest.LeetCode._3000_3999;

public class _3240_MinFlipsTest
{
    [Theory]
    [InlineData("[[1,0,0],[0,1,0],[0,0,1]]", 3)]
    [InlineData("[[1,1,1],[1,1,1],[1,1,1]]", 1)]
    [InlineData("[[0,0,1],[1,1,1]]", 2)]
    [InlineData("[[0,1],[0,1],[0,0]]", 2)]
    [InlineData("[[1],[1]]", 2)]
    public void MinFlips(string A, int expected)
    {
        var actual = _3240_MinFlips.MinFlips(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
