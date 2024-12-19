namespace playground.UnitTest._3200_3299;

public class _3251_CountOfPairsTest
{
    [Theory]
    [InlineData(new int[] { 2, 3, 2 }, 4)]
    [InlineData(new int[] { 5, 5, 5, 5 }, 126)]
    public void CountOfPairs(int[] nums, int expected)
    {
        var actual = CountOfPairs3250.CountOfPairs(nums);
        Assert.Equal(expected, actual);
    }
}
