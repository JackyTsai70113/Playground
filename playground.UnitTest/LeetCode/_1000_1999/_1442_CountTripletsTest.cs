using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1442_CountTripletsTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 1, 6, 7 }, 4)]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, 10)]
    public void CountTriplets(int[] arr, int expected)
    {
        var actual = _1442_CountTriplets.CountTriplets(arr);
        Assert.Equal(expected, actual);
    }
}
