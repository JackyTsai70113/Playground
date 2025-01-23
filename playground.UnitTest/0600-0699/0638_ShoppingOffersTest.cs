using playground._0600_0699;

namespace playground.UnitTest._0600_0699;

public class _0638_ShoppingOffersTest
{
    [Theory]
    [InlineData(new int[] { 2, 5 }, "[[3,0,5],[1,2,10]]", new int[] { 3, 2 }, 14)]
    [InlineData(new int[] { 2, 3, 4 }, "[[1,1,0,4],[2,2,1,9]]", new int[] { 1, 2, 1 }, 11)]
    [InlineData(new int[] { 2, 3, 4 }, "[[1,1,0,4],[1,2,1,7]]", new int[] { 1, 2, 1 }, 7)]
    [InlineData(new int[] { 2, 2 }, "[[1,1,1],[1,1,2],[1,1,3],[1,1,4],[1,1,5],[1,1,6],[1,1,7],[1,1,8],[1,1,9],[1,1,10],[1,1,11],[1,1,12],[1,1,13],[1,1,14],[1,1,15]]", new int[] { 10, 10 }, 10)]
    public void ShoppingOffers(int[] price, string special, int[] needs, int expected)
    {
        var actual = new _0638_ShoppingOffers().ShoppingOffers(price, special.To2dArr(), needs);
        Assert.Equal(expected, actual);
    }
}
