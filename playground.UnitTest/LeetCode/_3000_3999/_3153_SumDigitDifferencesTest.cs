namespace playground.UnitTest.LeetCode._3000_3999;

public class _3153_SumDigitDifferencesTest
{
    [Theory]
    [InlineData(new int[] { 13, 23, 12 }, 4)]
    [InlineData(new int[] { 10, 10, 10, 10 }, 0)]
    public static void SumDigitDifferences(int[] nums, long expected)
    {
        var actual = _3153_SumDigitDifferences.SumDigitDifferences(nums);
        Assert.Equal(expected, actual);
    }
}
