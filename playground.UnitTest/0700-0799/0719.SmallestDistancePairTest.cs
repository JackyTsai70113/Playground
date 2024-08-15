namespace playground.UnitTest;

public class SmallestDistancePairTest0719
{
    [Theory]
    [InlineData(new int[] { 1, 3, 1 }, 1, 0)]
    [InlineData(new int[] { 1, 1, 1 }, 2, 0)]
    [InlineData(new int[] { 1, 6, 1 }, 3, 5)]
    public void SmallestDistancePair(int[] nums, int k, int expected)
    {
        var actual = SmallestDistancePair0719.SmallestDistancePair(nums, k);
        Assert.Equal(expected, actual);
    }
}
