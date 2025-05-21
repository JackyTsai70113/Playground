using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0845_LongestMountainTest
{
    [Theory]
    [InlineData(new int[] { 2, 1, 4, 7, 3, 2, 5 }, 5)]
    [InlineData(new int[] { 2, 2, 2 }, 0)]
    [InlineData(new int[] { 0, 2, 0, 2, 1, 2, 3, 4, 4, 1 }, 3)]
    [InlineData(new int[] { 875, 884, 239, 731, 723, 685 }, 4)]
    public void LongestMountain(int[] arr, int expected)
    {
        int actual;
        actual = _0845_LongestMountain.LongestMountain_NotOnePass(arr);
        Assert.Equal(expected, actual);
        actual = _0845_LongestMountain.LongestMountain_OnePass(arr);
        Assert.Equal(expected, actual);
    }
}
