namespace playground.UnitTest;

public class FrequencySortTest1636
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2, 2, 2, 3 }, new int[] { 3, 1, 1, 2, 2, 2 })]
    [InlineData(new int[] { 2, 3, 1, 3, 2 }, new int[] { 1, 3, 3, 2, 2 })]
    [InlineData(new int[] { -1, 1, -6, 4, 5, -6, 1, 4, 1 }, new int[] { 5, -1, 4, 4, -6, -6, 1, 1, 1 })]
    public void FrequencySort(int[] nums, int[] expected)
    {
        var actual = FrequencySort1636.FrequencySort(nums);
        Assert.Equal(expected, actual);
    }
}
