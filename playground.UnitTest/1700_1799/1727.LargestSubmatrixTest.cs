namespace playground.UnitTest;

public class LargestSubmatrixTest_1727
{
    [Theory]
    [InlineData("[[0,0,1],[1,1,1],[1,0,1]]", 4)]
    [InlineData("[[1,0,1,0,1]]", 3)]
    public void LargestSubmatrix(string A, int expected)
    {
        var actual = LargestSubmatrix_1727.LargestSubmatrix(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
