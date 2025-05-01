using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0885_SpiralMatrixIIITest
{
    [Theory]
    [InlineData(1, 4, 0, 0, "[[0,0],[0,1],[0,2],[0,3]]")]
    [InlineData(5, 6, 1, 4, "[[1,4],[1,5],[2,5],[2,4],[2,3],[1,3],[0,3],[0,4],[0,5],[3,5],[3,4],[3,3],[3,2],[2,2],[1,2],[0,2],[4,5],[4,4],[4,3],[4,2],[4,1],[3,1],[2,1],[1,1],[0,1],[4,0],[3,0],[2,0],[1,0],[0,0]]")]
    public void SpiralMatrixIII(int rows, int cols, int r, int c, string expected)
    {
        var actual = new _0885_SpiralMatrixIII().SpiralMatrixIII(rows, cols, r, c);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
