using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2934_MinOperationsTest
{
    [Theory]
    [InlineData("[10,10,15,15]", "[10,16,15,15]", -1)]
    [InlineData("[10,18,12,12]", "[19,6,5,12]", -1)]
    [InlineData("[1,2,7]", "[4,5,3]", 1)]
    [InlineData("[4,5,3]", "[1,2,7]", 1)]
    [InlineData("[2,3,4,5,9]", "[8,8,4,4,4]", 2)]
    [InlineData("[1,5,4]", "[2,5,3]", -1)]
    [InlineData("[2,5,3]", "[1,5,4]", -1)]
    public void MinOperations(string nums1, string nums2, int expected)
    {
        var actual = _2934_MinOperations.MinOperations(nums1.ToArr(), nums2.ToArr());
        Assert.Equal(expected, actual);
    }
}
