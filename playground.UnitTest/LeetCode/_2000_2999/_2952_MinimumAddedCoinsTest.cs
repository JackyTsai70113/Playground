using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2952_MinimumAddedCoinsTest
{
    [Theory]
    [InlineData("[1,4,10]", 19, 2)]
    [InlineData("[1,4,10,5,7,19]", 19, 1)]
    [InlineData("[1,1,1]", 20, 3)]
    [InlineData("[1,12,15]", 43, 4)]
    [InlineData("[10,15,7,14,2,2,12,14,13]", 45, 2)]
    public void MinimumAddedCoins(string A, int target, int expected)
    {
        var actual = _2952_MinimumAddedCoins.MinimumAddedCoins(A.ToArr(), target);
        Assert.Equal(expected, actual);
    }
}
