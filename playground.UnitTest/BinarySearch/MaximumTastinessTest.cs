using playground.BinarySearch;

namespace playground.UnitTest.BinarySearch;

public class MaximumTastinessTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 3, 4 }, 3, 1)]
    [InlineData(new int[] { 2, 2, 2, 3, 3, 4 }, 3, 1)]
    [InlineData(new int[] { 10, 1, 3, 7, 5, 9, 5 }, 3, 4)]
    [InlineData(new int[] { 4, 2, 1 }, 2, 3)]
    [InlineData(new int[] { 4, 2, 2, 1 }, 2, 3)]
    public void MaximumTastiness(int[] price, int k, int expected)
    {
        var actual = MaximumTastinessClass.MaximumTastiness(price, k);
        Assert.Equal(expected, actual);
    }
}
