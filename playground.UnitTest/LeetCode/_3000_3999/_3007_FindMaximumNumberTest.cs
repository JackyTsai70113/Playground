namespace playground.UnitTest.LeetCode._3000_3999;

public class _3007_FindMaximumNumberTest
{
    [Theory]
    [InlineData(9, 1, 6)]
    [InlineData(7, 2, 9)]
    [InlineData(1000000000000000, 1, 44470852534271)]
    [InlineData(1000000000000000, 8, 343778878348159)]
    public void FindMaximumNumber(long k, int x, long expected)
    {
        var actual = _3007_FindMaximumNumber.FindMaximumNumber(k, x);
        Assert.Equal(expected, actual);
    }
}
