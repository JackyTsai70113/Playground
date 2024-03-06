namespace playground.UnitTest;

public class RestoreMatrixTest1605
{
    [Theory]
    [InlineData("[3,8]", "[4,7]", "[[3,0],[1,7]]")]
    [InlineData("[5,7,10]", "[8,6,8]", "[[5,0,0],[3,4,0],[0,2,8]]")]
    [InlineData("[10,7,5]", "[8,6,8]", "[[8,2,0],[0,4,3],[0,0,5]]")]
    public void RestoreMatrix(string rowSum, string colSum, string expected)
    {
        var actual = RestoreMatrix1605.RestoreMatrix(rowSum.ToArr(), colSum.ToArr());
        Assert.Equal(expected.To2dArr(), actual);
    }
}
