namespace playground.UnitTest;

public class _3276_MaxScoreTest
{
    [Theory]
    [InlineData("[[1,2,3],[4,3,2],[1,1,1]]", 8)]
    [InlineData("[[8,7,6],[8,3,2]]", 15)]
    public void MaxScore(string A, int expected)
    {
        var actual = _3276_MaxScore.MaxScore(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
