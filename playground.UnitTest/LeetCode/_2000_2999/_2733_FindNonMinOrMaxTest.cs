using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2733_FindNonMinOrMaxTest
{
    [Theory]
    [InlineData("[3,2,1,4]", "[2,3]")]
    [InlineData("[1,2]", "[-1]")]
    [InlineData("[2,1,3]", "[2]")]
    [InlineData("[3,30,24]", "[24]")]
    public void FindNonMinOrMax(string nums, string expected)
    {
        var actual = _2733_FindNonMinOrMax.FindNonMinOrMax(nums.ToArr());
        Assert.Contains(actual, expected.ToArr());
    }
}
