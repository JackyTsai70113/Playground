using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1072_MaxEqualRowsAfterFlipsTest
{
    [Theory]
    [InlineData("[[0,1]]", 1)]
    [InlineData("[[0,1],[1,1]]", 1)]
    [InlineData("[[0,1],[1,0]]", 2)]
    [InlineData("[[0,0,0],[0,0,1],[1,1,0]]", 2)]
    [InlineData("[[0],[1],[0],[0],[1],[1],[1],[1],[0],[1]]", 10)]
    [InlineData("[[1,0,0,0,1,0,0,1,1,0,0,0,0,1,0,0,1,1,1,1,1,1,1,0,1,1,0,1,1,1,0,0,0,1,0,1,1,0,1,0,0,1,0,1,0,1,0,1,1,0,0],[1,0,0,0,1,0,0,1,1,0,0,0,0,1,0,0,1,1,1,1,1,1,1,0,1,1,0,1,1,1,0,0,0,1,0,1,1,0,1,0,0,1,0,1,0,1,0,1,1,0,1]]", 1)]
    public void MaxEqualRowsAfterFlips(string matrix, int expected)
    {
        var actual = _1072_MaxEqualRowsAfterFlips.MaxEqualRowsAfterFlips(matrix.To2dArr());
        Assert.Equal(expected, actual);
    }
}
