namespace playground.UnitTest;

public class MatrixScoreTest0861
{
    [Theory]
    [InlineData("[[0,0,1,1],[1,0,1,0],[1,1,0,0]]", 39)]
    [InlineData("[[0]]", 1)]
    public void MatrixScore(string A, int expected)
    {
        var actual = MatrixScore0861.MatrixScore(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
