using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2944_MinimumCoinsTest
{
    [Theory]
    [InlineData("[3,1,2]", 4)]
    [InlineData("[1,10,1,1]", 2)]
    public void MinimumCoins(string A, int expected)
    {
        var actual = _2944_MinimumCoins.MinimumCoins(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
