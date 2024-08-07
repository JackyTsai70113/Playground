namespace playground.UnitTest;

public class ReversePairsTest0493
{
    [Theory]
    [InlineData(new int[] { 2147483647, 2147483647 }, 0)]
    [InlineData(new int[] { 3, 1 }, 1)]
    [InlineData(new int[] { 1, 3, 2, 3, 1 }, 2)]
    [InlineData(new int[] { 2, 4, 3, 5, 1 }, 3)]
    public void ReversePairs(int[] nums, int expected)
    {
        var actual = ReversePairs0493.ReversePairs(nums);
        Assert.Equal(expected, actual);
    }
}
