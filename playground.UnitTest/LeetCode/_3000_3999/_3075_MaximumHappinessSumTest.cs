namespace playground.UnitTest.LeetCode._3000_3999;

public class _3075_MaximumHappinessSumTest
{
    [Theory]
    [InlineData("[1,2,3]", 2, 4)]
    [InlineData("[1,1,1,1]", 2, 1)]
    [InlineData("[2,3,4,5]", 1, 5)]
    public void MaximumHappinessSum(string A, int k, long expected)
    {
        var actual = _3075_MaximumHappinessSum.MaximumHappinessSum(A.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
