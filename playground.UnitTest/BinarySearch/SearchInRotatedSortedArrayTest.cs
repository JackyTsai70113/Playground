using playground.BinarySearch;

namespace playground.UnitTest.BinarySearch;

public class SearchInRotatedSortedArrayTest
{
    [Theory]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 1, 5)]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 2, 6)]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 4, 0)]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 5, 1)]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 6, 2)]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 7, 3)]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 8, -1)]
    [InlineData(new int[] { 1 }, 0, -1)]
    public void Search(int[] nums, int target, int expected)
    {
        var actual = SearchInRotatedSortedArrayClass.SearchInRotatedSortedArray(nums, target);

        Assert.Equal(expected, actual);
    }
}
