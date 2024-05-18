namespace playground.UnitTest;

public class MinimumOperationsToMakeKPeriodicTest3137
{
    [Theory]
    [InlineData("leetcodeleet", 4, 1)]
    [InlineData("leetcoleet", 2, 3)]
    public void MinimumOperationsToMakeKPeriodic(string word, int k, int expected)
    {
        var actual = MinimumOperationsToMakeKPeriodic3137.MinimumOperationsToMakeKPeriodic(word, k);
        Assert.Equal(expected, actual);
    }
}
