using playground.BinarySearch;
using playground.UnitTest.Utils;

namespace playground.UnitTest.BinarySearch;

public class SearchTest
{
    [Theory]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
    [InlineData(new int[] { 1 }, 0, -1)]
    public void Search(int[] nums, int target, int expected)
    {
        var actual = SearchClass.Search(nums, target);

        Assert.Equal(expected, actual);
    }
}
