using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3591_CheckPrimeFrequencyTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 4 }, true)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, false)]
    [InlineData(new[] { 2, 2, 2, 4, 4 }, true)]
    [InlineData(new[] { 1, 1, 1, 1 }, false)]
    [InlineData(new[] { 2, 3, 5, 7 }, false)]
    [InlineData(new[] { 4, 6, 8 }, false)]
    public void CheckPrimeFrequency(int[] nums, bool expected)
    {
        var actual = _3591_CheckPrimeFrequency.CheckPrimeFrequency(nums);
        Assert.Equal(expected, actual);
    }
}
