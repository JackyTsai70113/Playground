using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2926_MaxBalancedSubsequenceSumTest
{
    [Theory]
    [InlineData("[3,3,5,6]", 14)]
    [InlineData("[5,-1,-3,8]", 13)]
    [InlineData("[-2,-1]", -1)]
    public void MaxBalancedSubsequenceSum(string numsStr, long expected)
    {
        var nums = numsStr.ToArr();
        var actual = _2926_MaxBalancedSubsequenceSum.MaxBalancedSubsequenceSum(nums);
        Assert.Equal(expected, actual);
    }
}
