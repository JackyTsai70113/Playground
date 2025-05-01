namespace playground.UnitTest;

public class _3274_CheckTwoChessboardsTest
{
    [Theory]
    [InlineData("a1", "c3", true)]
    [InlineData("a1", "h3", false)]
    public void CheckTwoChessboards(string c1, string c2, bool expected)
    {
        var actual = _3274_CheckTwoChessboards.CheckTwoChessboards(c1, c2);
        Assert.Equal(expected, actual);
    }
}
