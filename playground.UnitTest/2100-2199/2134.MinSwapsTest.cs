namespace playground.UnitTest;

public class MinSwapsTest2134
{
    [Theory]
    [InlineData(new int[] { 0 }, 0)]
    [InlineData(new int[] { 0, 1, 0, 1, 1, 0, 0 }, 1)]
    [InlineData(new int[] { 0, 1, 1, 1, 0, 0, 1, 1, 0 }, 2)]
    [InlineData(new int[] { 1, 1, 0, 0, 1 }, 0)]
    [InlineData(new int[] { 0, 0, 0 }, 0)]
    [InlineData(new int[] { 1, 1, 1 }, 0)]
    [InlineData(new int[] { 1, 1, 1, 0, 0, 1, 0, 1, 1, 0 }, 1)]
    public void MinSwaps(int[] nums, int expected)
    {
        var actual = MinSwaps2134.MinSwaps(nums);
        Assert.Equal(expected, actual);
    }
}
