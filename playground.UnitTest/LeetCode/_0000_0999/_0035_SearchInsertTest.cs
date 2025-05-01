using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0035_SearchInsertTest
{
    [Theory]
    [InlineData("[1,3,5,6]", 0, 0)]
    [InlineData("[1,3,5,6]", 2, 1)]
    [InlineData("[1,3,5,6]", 5, 2)]
    [InlineData("[1,3,5,6]", 7, 4)]
    public void SearchInsert(string nums, int target, int expected)
    {
        var actual = _0035_SearchInsert.SearchInsert(nums.ToArr(), target);
        Assert.Equal(expected, actual);
    }
}
