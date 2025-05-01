using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0852_PeakIndexInMountainArrayTest
{
    [Theory]
    [InlineData(new int[] { 0, 1, 0 }, 1)]
    [InlineData(new int[] { 0, 2, 1, 0 }, 1)]
    [InlineData(new int[] { 0, 10, 5, }, 1)]
    [InlineData(new int[] { 0, 4, 3, 2, 0 }, 1)]
    [InlineData(new int[] { 3, 4, 5, 1 }, 2)]
    [InlineData(new int[] { 40, 48, 61, 75, 100, 99, 98, 39, 30, 10 }, 4)]
    public void PeakIndexInMountainArray(int[] arr, int expected)
    {
        var actual = _0852_PeakIndexInMountainArray.PeakIndexInMountainArray(arr);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 0, 1, 0 }, 1)]
    [InlineData(new int[] { 0, 2, 1, 0 }, 1)]
    [InlineData(new int[] { 0, 10, 5, }, 1)]
    [InlineData(new int[] { 0, 4, 3, 2, 0 }, 1)]
    [InlineData(new int[] { 3, 4, 5, 1 }, 2)]
    [InlineData(new int[] { 40, 48, 61, 75, 100, 99, 98, 39, 30, 10 }, 4)]
    public void PeakIndexInMountainArray2(int[] arr, int expected)
    {
        var actual = _0852_PeakIndexInMountainArray.PeakIndexInMountainArray2(arr);
        Assert.Equal(expected, actual);
    }
}
