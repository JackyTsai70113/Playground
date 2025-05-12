using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3251_CountOfPairsTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 2 }, 4)]
    [InlineData(new int[] { 5, 5, 5, 5 }, 126)]
    [InlineData(new int[] { 40, 91, 187, 256, 334, 337, 694, 749, 782, 833 }, 272278100)]
    public void CountOfPairs(int[] nums, int expected)
    {
        var actual = _3251_CountOfPairs.CountOfPairs(nums);
        Assert.Equal(expected, actual);
    }
}
