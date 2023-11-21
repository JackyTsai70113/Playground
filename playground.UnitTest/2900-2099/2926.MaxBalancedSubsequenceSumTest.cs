namespace playground.UnitTest;

public class MaxBalancedSubsequenceSumTest_2926
{
    [Theory]
    [InlineData("[3,3,5,6]", 14)]
    [InlineData("[5,-1,-3,8]", 13)]
    [InlineData("[-2,-1]", -1)]
    public void MaxBalancedSubsequenceSum(string numsStr, long expected)
    {
        var nums = numsStr.ToArr();
        var actual = MaxBalancedSubsequenceSum_2926.MaxBalancedSubsequenceSum(nums);
        Assert.Equal(expected, actual);
    }
}
