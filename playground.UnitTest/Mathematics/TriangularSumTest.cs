using playground.Mathematics;

namespace playground.UnitTest.Mathematics;

public class TriangularSumTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 8)]
    [InlineData(new int[] { 5 }, 5)]
    [InlineData(new int[] { 2, 6, 6, 5, 5, 3, 3, 8, 6, 4, 3, 3, 5, 1, 0, 1, 3, 6, 9 }, 0)]
    [InlineData(new int[] { 2, 6, 6, 5, 5, 3 }, 0)]
    [InlineData(new int[] { 2, 6, 6, 5, 5, 3, 3, 8, 6 }, 0)]
    [InlineData(new int[] { 2, 6, 6, 5, 5, 3, 3, 8, 6, 4 }, 8)]
    public void TriangularSum(int[] nums, int expected)
    {
        var actual = TriangularSumClass.TriangularSum(nums);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 8)]
    [InlineData(new int[] { 5 }, 5)]
    [InlineData(new int[] { 2, 6, 6, 5, 5, 3, 3, 8, 6, 4, 3, 3, 5, 1, 0, 1, 3, 6, 9 }, 0)]
    [InlineData(new int[] { 2, 6, 6, 5, 5, 3 }, 0)]
    [InlineData(new int[] { 2, 6, 6, 5, 5, 3, 3, 8, 6 }, 0)]
    [InlineData(new int[] { 2, 6, 6, 5, 5, 3, 3, 8, 6, 4 }, 8)]
    public void TriangularSum2(int[] nums, int expected)
    {
        var actual = TriangularSumClass.TriangularSum2(nums);
        Assert.Equal(expected, actual);
    }
}
