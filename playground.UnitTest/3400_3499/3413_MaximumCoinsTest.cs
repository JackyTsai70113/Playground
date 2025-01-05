using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

public class _3413_MaximumCoinsTest
{
    [Theory]
    [InlineData("[[8,10,1],[1,3,2],[5,6,4]]", 4, 10)]
    [InlineData("[[1,10,3]]", 2, 6)]
    [InlineData("[[1,1000000000,1000]]", 1000000000, 1000000000000)]
    [InlineData("[[9,10,16]]", 21, 32)]
    public void MinStartingIndex(string A, int k, long expected)
    {
        var actual = _3413_MaximumCoins.MaximumCoins(A.To2dArr(), k);
        Assert.Equal(expected, actual);
    }
}
