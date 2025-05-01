using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0861_MatrixScoreTest
{
    [Theory]
    [InlineData("[[0,0,1,1],[1,0,1,0],[1,1,0,0]]", 39)]
    [InlineData("[[0]]", 1)]
    public void MatrixScore(string A, int expected)
    {
        var actual = _0861_MatrixScore.MatrixScore(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
