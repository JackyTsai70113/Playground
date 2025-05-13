using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3434_MaxFrequencyTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 1, 2)]
    [InlineData(new int[] { 10, 2, 3, 4, 5, 5, 4, 3, 2, 2 }, 10, 4)]
    [InlineData(new int[] { 2, 8 }, 8, 2)]
    [InlineData(new int[] { 9, 8, 9, 4, 4 }, 4, 4)]
    [InlineData(new int[] { 9, 8, 9, 9, 4, 4, 9, 9, 9 }, 4, 6)]
    public void MaxFrequency(int[] nums, int k, int expected)
    {
        var actual = _3434_MaxFrequency.MaxFrequency(nums, k);
        Assert.Equal(expected, actual);
    }
}
