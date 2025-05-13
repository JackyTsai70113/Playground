namespace playground.UnitTest.LeetCode._3000_3999;

public class _3148_MaxScoreTest
{
    [Theory]
    [InlineData("[[9,5,7,3],[8,9,6,1],[6,7,14,3],[2,5,3,1]]", 9)]
    [InlineData("[[4,3,2],[3,2,1]]", -1)]
    public void MaximumSafenessFactor(string A, int expected)
    {
        var actual = _3148_MaxScore.MaxScore(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
