using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0220_ContainsNearbyAlmostDuplicateTest
{
    [Theory]
    [InlineData("[-3,3]", 2, 4, false)]
    [InlineData("[1,3,6,2]", 1, 2, true)]
    [InlineData("[4,1,6,3]", 4, 1, true)]
    [InlineData("[1,2,3,1]", 3, 0, true)]
    [InlineData("[1,5,9,1,5,9]", 2, 3, false)]
    public void ContainsNearbyAlmostDuplicate(string nums, int indexDiff, int valueDiff, bool expected)
    {
        var actual = _0220_ContainsNearbyAlmostDuplicate.ContainsNearbyAlmostDuplicate(nums.ToArr(), indexDiff, valueDiff);
        Assert.Equal(expected, actual);
    }
}
