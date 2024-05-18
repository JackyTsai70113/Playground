namespace playground.UnitTest;

public class MaxScoreTest3148
{
    [Theory]
    [InlineData("[[9,5,7,3],[8,9,6,1],[6,7,14,3],[2,5,3,1]]", 9)]
    [InlineData("[[4,3,2],[3,2,1]]", -1)]
    public void MaximumSafenessFactor(string A, int expected)
    {
        var actual = MaxScore3148.MaxScore(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
