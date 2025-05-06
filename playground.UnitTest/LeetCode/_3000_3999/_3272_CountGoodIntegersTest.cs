using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3272_CountGoodIntegersTest
{
    [Theory]
    [InlineData(3, 5, 27)]
    [InlineData(1, 4, 2)]
    [InlineData(5, 6, 2468)]
    [InlineData(10, 9, 4610368)]
    public void CountGoodIntegers(int n, int k, long expected)
    {
        var actual = new _3272_CountGoodIntegers().CountGoodIntegers(n, k);
        Assert.Equal(expected, actual);
    }
}
