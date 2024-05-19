namespace playground.UnitTest;

public class SumDigitDifferencesTest3153
{
    [Theory]
    [InlineData(new int[] { 13, 23, 12 }, 4)]
    [InlineData(new int[] { 10, 10, 10, 10 }, 0)]
    public static void SumDigitDifferences(int[] nums, long expected)
    {
        var actual = SumDigitDifferences3153.SumDigitDifferences(nums);
        Assert.Equal(expected, actual);
    }
}
