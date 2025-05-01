namespace playground.UnitTest;

public class _3209_CountSubarraysTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1 }, 1, 6)]
    [InlineData(new int[] { 1, 1, 2 }, 1, 3)]
    [InlineData(new int[] { 1, 2, 3 }, 2, 2)]
    [InlineData(new int[] { 0, 0, 4, 6, 2 }, 6, 1)]
    [InlineData(new int[] { 1, 9, 9, 7, 4 }, 1, 6)]
    public void MinOperations(int[] nums, int k, long expected)
    {
        var actual = _3209_CountSubarrays.CountSubarrays(nums, k);
        Assert.Equal(expected, actual);
    }
}
