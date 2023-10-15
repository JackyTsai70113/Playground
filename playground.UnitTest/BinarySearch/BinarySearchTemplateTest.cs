using playground.BinarySearch;

namespace playground.UnitTest.BinarySearch;

public class BinarySearchTemplateTest
{
    [Theory] //             0  1  2  3  4  5  6  7
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 0, -1, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 1, 0, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 2, 3, 3)]
    [InlineData(new int[] { 1, 2, 2, 2, 2, 4, 5, 5, 6 }, 2, 4, 4)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 3, -5, 4)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 4, 4, 4)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 5, 5, 5)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 6, 7, 7)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 7, -9, 8)]
    public void ArrayBinarySearch(int[] nums, int p, int expected, int expected2)
    {
        int actual = BinarySearchTemplateClass.ArrayBinarySearch(nums, p);

        Assert.Equal(expected, actual);
        if (actual < 0) actual = ~actual;
        Assert.Equal(expected2, actual);
    }

    [Theory] //             0  1  2  3  4  5  6  7 => 有重複的元素則不會是最小 index
    [InlineData(new int[] { 1, 1, 1, 1, 2, 2, 2, 2 }, 4, 4, 2, 5, 5)]
    [InlineData(new int[] { 1, 1, 1, 1, 2, 2, 2, 2 }, 3, 4, 2, 4, 4)]
    [InlineData(new int[] { 1, 1, 1, 1, 2, 2, 2, 2 }, 2, 4, 2, 4, 4)]
    public void ArrayBinarySearchWithLength(int[] nums, int index, int length, int p, int expected, int expected2)
    {
        int actual = BinarySearchTemplateClass.ArrayBinarySearch(nums, index, length, p);

        Assert.Equal(expected, actual);
        if (actual < 0) actual = ~actual;
        Assert.Equal(expected2, actual);
    }

    [Theory] //             0  1  2  3  4  5  6  7
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 0, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 1, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 2, 1)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 3, 4)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 4, 4)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 5, 5)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 6, 7)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 7, 8)]
    public void GetLowerBoundWithFunc(int[] nums, int p, int expected)
    {
        int actual = BinarySearchTemplateClass.GetLowerBound(nums, 0, nums.Length, (val) => val >= p);

        Assert.Equal(expected, actual);
    }

    [Theory] //             0  1  2  3  4  5  6  7
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 0, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 1, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 2, 1)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 3, 4)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 4, 4)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 5, 5)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 6, 7)]
    [InlineData(new int[] { 1, 2, 2, 2, 4, 5, 5, 6 }, 7, 8)]
    public void GetLowerBound(int[] nums, int p, int expected)
    {
        int actual = BinarySearchTemplateClass.GetLowerBound(nums, p);

        Assert.Equal(expected, actual);
    }

    [Theory] //             0  1  2  3  4  5  6  7
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 0, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 1, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 2, 3)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 3, 4)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 4, 6)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 5, 7)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 6, 7)]
    [InlineData(new int[] { }, 5, 0)]
    public void GetUpperBound(int[] nums, int p, int expected)
    {
        int actual = BinarySearchTemplateClass.GetUpperBound(nums, p);

        Assert.Equal(expected, actual);
    }
}
