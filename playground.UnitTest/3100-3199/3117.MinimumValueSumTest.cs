namespace playground.UnitTest;

public class MinimumValueSumTest3117
{
    [Theory]
    [InlineData(new int[] { 1 }, new int[] { 1 }, 1)]
    [InlineData(new int[] { 1, 2 }, new int[] { 0 }, 2)]
    [InlineData(new int[] { 1, 2 }, new int[] { 3 }, -1)]
    [InlineData(new int[] { 1, 4, 3, 3, 2 }, new int[] { 0, 3, 3, 2 }, 12)]
    [InlineData(new int[] { 1, 3, 2, 4, 7, 5, 3 }, new int[] { 0, 5, 3 }, 12)]
    [InlineData(new int[] { 2, 3, 5, 7, 7, 7, 5 }, new int[] { 0, 7, 5 }, 17)]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 2 }, -1)]
    [InlineData(new int[] { 32, 114, 114, 105, 61, 37, 49, 49, 122, 60, 38, 55, 114, 110, 37, 96, 62, 34, 122, 97, 98, 122, 49, 106, 99, 54, 57, 32, 125, 38, 36, 48, 62, 105, 41, 119, 33, 54, 125, 96, 126, 127, 124, 40, 50, 57, 47, 62, 97, 42, 58, 34, 119, 44, 58, 40, 60, 47, 63, 117, 35, 124, 41, 116, 53, 127, 48, 52, 33, 99, 98, 100, 56, 54, 61, 61, 104, 42, 110, 39, 53, 38, 101, 49, 50, 123, 40, 32, 123, 56, 115, 33, 63, 99, 99, 100, 61, 47, 99, 57 }, new int[] { 32, 32, 32, 32, 32, 32, 33 }, 266)]
    public void MinimumValueSum(int[] nums, int[] andValues, int expected)
    {
        var actual = MinimumValueSum3117.MinimumValueSum(nums, andValues);
        Assert.Equal(expected, actual);
    }
}
