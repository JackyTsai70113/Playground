using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0167_TwoSumTest
{
    [Theory]
    [InlineData("[2,7,11,15]", 9, "[1,2]")]
    [InlineData("[2,7,11,15]", 26, "[3,4]")]
    [InlineData("[2,3,4]", 6, "[1,3]")]
    [InlineData("[-1,0]", -1, "[1,2]")]
    public void TwoSum(string A, int target, string expected)
    {
        var actual = _0167_TwoSum.TwoSum(A.ToArr(), target);
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }
}
