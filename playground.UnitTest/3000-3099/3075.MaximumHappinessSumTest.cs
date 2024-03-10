namespace playground.UnitTest;

public class MaximumHappinessSumTest3075
{
    [Theory]
    [InlineData("[1,2,3]", 2, 4)]
    [InlineData("[1,1,1,1]", 2, 1)]
    [InlineData("[2,3,4,5]", 1, 5)]
    public void MaximumHappinessSum(string A, int k, long expected)
    {
        var actual = MaximumHappinessSum3075.MaximumHappinessSum(A.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
