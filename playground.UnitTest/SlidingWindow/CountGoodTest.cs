using playground.SlidingWindow;

namespace playground.UnitTest.SlidingWindow;

public class CountGoodTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, 10, 1)]
    [InlineData(new int[] { 3, 1, 4, 3, 2, 2, 4 }, 2, 4)]
    public void CountGood(int[] nums, int k, int expected)
    {
        var actual = CountGoodClass.CountGood(nums, k);
        Assert.Equal(expected, actual);
    }
}
