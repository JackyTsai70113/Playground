using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2972_IncremovableSubarrayCountTest
{
    [Theory]
    [InlineData("[1,2,3,4]", 10)]
    [InlineData("[6,5,7,8]", 7)]
    [InlineData("[8,7,6,6]", 3)]
    public void IncremovableSubarrayCount(string nums, int expected)
    {
        var actual = _2972_IncremovableSubarrayCount.IncremovableSubarrayCount(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
