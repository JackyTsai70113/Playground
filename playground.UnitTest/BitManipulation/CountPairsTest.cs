using playground.BitManipulation;

namespace playground.UnitTest.BitManipulation;

public class CountPairsTest
{
    [Theory]
    [InlineData(new int[] { 1, 4, 2, 7 }, 2, 6, 6)]
    [InlineData(new int[] { 9, 8, 4, 2, 1 }, 5, 14, 8)]
    public void CountPairs(int[] nums, int low, int high, int expected)
    {
        var actual = CountPairsClass.CountPairs(nums, low, high);
        Assert.Equal(expected, actual);
    }
}
