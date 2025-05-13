namespace playground.UnitTest.LeetCode._1000_1999;

public class _1793_MaximumScoreTest
{
    [Theory]
    [InlineData("[1,4,3,7,4,5]", 3, 15)]
    [InlineData("[5,5,4,5,4,1,1,1]", 0, 20)]
    [InlineData("[6569,9667,3148,7698,1622,2194,793,9041,1670,1872]", 5, 9732)]
    public void MaximumScore(string A, int k, int expected)
    {
        var actual = _1793_MaximumScore.MaximumScore(A.ToArr(), k);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[1,4,3,7,4,5]", 3, 15)]
    [InlineData("[5,5,4,5,4,1,1,1]", 0, 20)]
    [InlineData("[6569,9667,3148,7698,1622,2194,793,9041,1670,1872]", 5, 9732)]
    public void MaximumScore2(string A, int k, int expected)
    {
        var actual = _1793_MaximumScore.MaximumScore2(A.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
