using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2326_SpiralMatrixTest
{
    [Theory]
    [InlineData(3, 5, "[3,0,2,6,8,1,7,9,4,2,5,5,0]", "[[3,0,2,6,8],[5,0,-1,-1,1],[5,2,4,9,7]]")]
    [InlineData(1, 4, "[0, 1, 2]", "[[0, 1, 2, -1]]")]
    public void SpiralMatrix(int m, int n, string head, string expected)
    {
        var actual = _2326_SpiralMatrix.SpiralMatrix(m, n, head.ToListNode());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
