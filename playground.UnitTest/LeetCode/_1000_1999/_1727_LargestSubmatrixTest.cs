namespace playground.UnitTest.LeetCode._1000_1999;

public class _1727_LargestSubmatrixTest
{
    [Theory]
    [InlineData("[[0,0,1],[1,1,1],[1,0,1]]", 4)]
    [InlineData("[[1,0,1,0,1]]", 3)]
    public void LargestSubmatrix(string A, int expected)
    {
        var actual = _1727_LargestSubmatrix.LargestSubmatrix(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
