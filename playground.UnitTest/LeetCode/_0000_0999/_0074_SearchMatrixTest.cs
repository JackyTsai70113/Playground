using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0074_SearchMatrixTest
{
    [Theory]
    [InlineData("[[1,3,5,7],[10,11,16,20],[23,30,34,60]]", 3, true)]
    [InlineData("[[1,3,5,7],[10,11,16,20],[23,30,34,60]]", 13, false)]
    [InlineData("[[1],[3]]", 3, true)]
    public void SearchMatrix(string nums, int target, bool expected)
    {
        var actual = _0074_SearchMatrix.SearchMatrix(nums.To2dArr(), target);
        Assert.Equal(expected, actual);
    }
}
