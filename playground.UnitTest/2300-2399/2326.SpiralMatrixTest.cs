namespace playground.UnitTest;

public class SpiralMatrixTest2326
{
    [Theory]
    [InlineData(3, 5, "[3,0,2,6,8,1,7,9,4,2,5,5,0]", "[[3,0,2,6,8],[5,0,-1,-1,1],[5,2,4,9,7]]")]
    [InlineData(1, 4, "[0, 1, 2]", "[[0, 1, 2, -1]]")]
    public void SpiralMatrix(int m, int n, string head, string expected)
    {
        var actual = SpiralMatrix2326.SpiralMatrix(m, n, head.ToListNode());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
