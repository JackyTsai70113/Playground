using playground._1600_1699;

namespace playground.UnitTest._1600_1699;

public class _1695_MaximumUniqueSubarrayTest
{
    [Theory]
    [InlineData(new int[] { 4, 2, 4, 5, 6 }, 17)]
    [InlineData(new int[] { 5, 2, 1, 2, 5, 2, 1, 2, 5 }, 8)]
    public void GetSumAbsoluteDifferences(int[] nums, int expected)
    {
        var actual = _1695_MaximumUniqueSubarray_cs.MaximumUniqueSubarray(nums);
        Assert.Equal(expected, actual);
    }
}
