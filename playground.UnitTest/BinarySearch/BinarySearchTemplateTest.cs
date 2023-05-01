using playground.BinarySearch;

namespace playground.UnitTest.BinarySearch;

public class BinarySearchTemplateTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 0, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 1, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 2, 1)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 3, 4)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 4, 5)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 5, 7)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 6, 7)]
    public void GetLowerBound(int[] nums, int p, int expect)
    {
        int result = BinarySearchTemplateClass.GetLowerBound(nums, p);

        Assert.Equal(expect, result);
    }

    [Theory] //             0  1  2  3  4  5  6  7
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 0, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 1, 0)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 2, 3)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 3, 4)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 4, 6)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 5, 7)]
    [InlineData(new int[] { 1, 2, 2, 2, 3, 4, 4, 5 }, 6, 7)]
    [InlineData(new int[] {  }, 5, 0)]
    public void GetUpperBound(int[] nums, int p, int expect)
    {
        int result = BinarySearchTemplateClass.GetUpperBound(nums, p);

        Assert.Equal(expect, result);
    }
}
