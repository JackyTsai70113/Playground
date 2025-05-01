using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2824_CountPairsTest
{
    [Theory]
    [InlineData("[-1,1,2,3,1]", 2, 3)]
    [InlineData("[-6,2,5,-2,-7,-1,3]", -2, 10)]
    public void CountPairs(string nums, int target, int expected)
    {
        var actual = _2824_CountPairs.CountPairs(nums.ToArr(), target);
        Assert.Equal(expected, actual);
    }
}
