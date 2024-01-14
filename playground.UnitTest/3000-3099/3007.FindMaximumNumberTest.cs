namespace playground.UnitTest;

public class FindMaximumNumberTest3007
{
    [Theory]
    [InlineData(9, 1, 6)]
    [InlineData(7, 2, 9)]
    [InlineData(1000000000000000, 1, 44470852534271)]
    [InlineData(1000000000000000, 8, 343778878348159)]
    public void FindMaximumNumber(long k, int x, long expected)
    {
        var actual = FindMaximumNumber3007.FindMaximumNumber(k, x);
        Assert.Equal(expected, actual);
    }
}
