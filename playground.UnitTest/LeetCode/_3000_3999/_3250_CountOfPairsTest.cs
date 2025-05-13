using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3250_CountOfPairsTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 2 }, 4)]
    [InlineData(new int[] { 5, 5, 5, 5 }, 126)]
    public void CountOfPairs(int[] nums, int expected)
    {
        var actual = _3250_CountOfPairs.CountOfPairs(nums);
        Assert.Equal(expected, actual);
    }
}
