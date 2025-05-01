using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0219_ContainsNearbyDuplicateTest
{
    [Theory]
    [InlineData("[1,2,3,1]", 3, true)]
    [InlineData("[1,0,1,1]", 1, true)]
    [InlineData("[1,2,3,1,2,3]", 2, false)]
    public void ContainsNearbyDuplicate(string nums, int k, bool expected)
    {
        var actual = _0219_ContainsNearbyDuplicate.ContainsNearbyDuplicate(nums.ToArr(), k);
        Assert.Equal(expected, actual);
    }
}
