namespace playground.UnitTest;

public class DistributeCandiesTest_2928
{
    [Theory]
    [InlineData(5, 2, 3)]
    [InlineData(3, 3, 10)]
    public void DistributeCandies(int n, int limit, int expected)
    {
        var actual = DistributeCandies_2928.DistributeCandies(n, limit);
        Assert.Equal(expected, actual);
    }
}
