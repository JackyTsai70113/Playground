namespace playground.UnitTest;

public class FindPrimePairsTest2761
{
    [Theory]
    [InlineData(10, "[[3,7],[5,5]]")]
    [InlineData(2, "[]")]
    public void FindPrimePairs(int n, string expected)
    {
        var actual = FindPrimePairs2761.FindPrimePairs(n);
        Assert.Equal(expected.To2dArr(), actual);
    }
}
