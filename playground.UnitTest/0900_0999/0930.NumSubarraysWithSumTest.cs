using playground._0900_0999;

namespace playground.UnitTest_0900_0999;

public class NumSubarraysWithSumTest0930
{
    [Theory]
    [InlineData(new int[] { 1, 0, 1, 0, 1 }, 2, 4)]
    [InlineData(new int[] { 0, 0, 0, 0, 0 }, 0, 15)]
    public void NumSubarraysWithSum(int[] nums, int goal, int expected)
    {
        var actual = _0930_NumSubarraysWithSum.NumSubarraysWithSum(nums, goal);
        Assert.Equal(expected, actual);
    }
}
