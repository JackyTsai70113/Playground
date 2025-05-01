using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0001_TwoSumTest
{
    [Theory]
    [InlineData("[2,7,11,15]", 9, "[1,0]")]
    [InlineData("[3,2,4]", 6, "[2,1]")]
    [InlineData("[3,3]", 6, "[1,0]")]
    public void TwoSum(string A, int target, string expected)
    {
        var actual = _0001_TwoSum.TwoSum(A.ToArr(), target);
        Assert.Equal(expected.ToArr(), actual);
    }
}
