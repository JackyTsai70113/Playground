using playground.BinarySearch;

namespace playground.UnitTest.BinarySearch;

public class MinimizeMaxTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 3, 4 }, 3, 1)]
    [InlineData(new int[] { 2, 2, 2, 3, 3, 4 }, 3, 1)]
    [InlineData(new int[] { 10, 1, 3, 7, 5, 9, 5 }, 3, 2)]
    [InlineData(new int[] { 4, 2, 1 }, 1, 1)]
    [InlineData(new int[] { 3, 0, 5, 0, 0, 1, 6 }, 3, 1)]
    [InlineData(new int[] { 4, 2, 2, 1 }, 1, 0)]
    [InlineData(new int[] { 1 }, 0, 0)]
    [InlineData(new int[] { 1, 2 }, 0, 0)]
    public void MinimizeMax(int[] nums, int p, int expected)
    {
        int actual = MinimizeMaxClass.MinimizeMax(nums, p);

        Assert.Equal(expected, actual);
    }
}