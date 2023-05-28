using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class DistinctDifferenceArrayTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { -3, -1, 1, 3, 5 })]
    [InlineData(new int[] { 3, 2, 3, 4, 2 }, new int[] { -2, -1, 0, 2, 3 })]
    public void DistinctDifferenceArray(int[] nums, int[] expected)
    {
        var actual = DistinctDifferenceArrayClass.DistinctDifferenceArray(nums);
        Assert.Equal(expected, actual);
    }
}
