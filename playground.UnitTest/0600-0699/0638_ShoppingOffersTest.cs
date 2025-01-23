using playground._0600_0699;

namespace playground.UnitTest._0600_0699;

public class _0638_ShoppingOffersTest
{
    [Theory]
    [InlineData(new int[] { 2, 5 }, "[[3,0,5],[1,2,10]]", new int[] { 3, 2 }, 14)]
    [InlineData(new int[] { 2, 3, 4 }, "[[1,1,0,4],[2,2,1,9]]", new int[] { 1, 2, 1 }, 11)]
    [InlineData(new int[] { 2, 3, 4 }, "[[1,1,0,4],[1,2,1,7]]", new int[] { 1, 2, 1 }, 7)]
    public void ShoppingOffers(int[] price, string special, int[] needs, int expected)
    {
        var actual = _0638_ShoppingOffers.ShoppingOffers(price, special.To2dArr(), needs);
        Assert.Equal(expected, actual);
    }
}
