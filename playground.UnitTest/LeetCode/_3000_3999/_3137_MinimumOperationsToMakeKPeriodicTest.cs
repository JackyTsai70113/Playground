namespace playground.UnitTest;

public class _3137_MinimumOperationsToMakeKPeriodicTest
{
    [Theory]
    [InlineData("leetcodeleet", 4, 1)]
    [InlineData("leetcoleet", 2, 3)]
    public void MinimumOperationsToMakeKPeriodic(string word, int k, int expected)
    {
        var actual = _3137_MinimumOperationsToMakeKPeriodic.MinimumOperationsToMakeKPeriodic(word, k);
        Assert.Equal(expected, actual);
    }
}
