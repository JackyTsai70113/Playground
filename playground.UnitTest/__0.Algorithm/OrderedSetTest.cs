namespace playground.UnitTest;

public class OrderedSetTest
{
    [Theory]
    [InlineData(new int[] { 5, 6, 7, 8, 8, 4, 3, 2, 1 }, 4, 7, new int[] { 4, 5, 6, 7 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8 }, 4, 10, new int[] { 4, 5, 6, 7, 8 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 8 }, 0, 10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
    public void GetViewBetween(int[] arr, int l, int r, int[] expected)
    {
        var actual = OrderedSet.GetViewBetween(arr, l, r);
        Assert.Equal(expected, actual);
    }
}
