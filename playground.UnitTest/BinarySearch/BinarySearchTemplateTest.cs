using playground.BinarySearch;

namespace playground.UnitTest.BinarySearch;

public class BinarySearchTemplateTest
{
    [Theory]             // 0  1  2  3  4  5  6  7
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 0, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 1, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 2, 1)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 3, 4)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 4, 4)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 5, 5)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 6, 7)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 7, 8)]
    [InlineData(new int[] { }, 5, 0)]
    public void GetLowerBoundWithFunc(int[] nums, int p, int expected)
    {
        int actual = BinarySearchTemplateClass.GetLowerBound(nums, 0, nums.Length, (val) => val >= p);

        Assert.Equal(expected, actual);
    }

    [Theory]             // 0  1  2  3  4  5  6  7
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 0, -1)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 1, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 2, 3)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 3, 4)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 4, 6)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 5, 7)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 6, 7)]
    [InlineData(new int[] { }, 5, -1)]
    public void GetUpperBound(int[] nums, int p, int expected)
    {
        int actual = BinarySearchTemplateClass.GetUpperBound(nums, -1, nums.Length - 1, (val) => val <= p);

        Assert.Equal(expected, actual);
    }
}
