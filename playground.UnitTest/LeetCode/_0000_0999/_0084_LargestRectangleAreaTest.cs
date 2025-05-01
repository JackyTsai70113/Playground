using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0084_LargestRectangleAreaTest
{
    [Theory]
    [InlineData("[2,1,5,6,2,3]", 10)]
    [InlineData("[2,4]", 4)]
    public void LargestRectangleArea(string A, int expected)
    {
        var actual = _0084_LargestRectangleArea.LargestRectangleArea(A.ToArr());
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("[2,1,5,6,2,3]", 10)]
    [InlineData("[2,4]", 4)]
    public void LargestRectangleArea2(string A, int expected)
    {
        var actual = _0084_LargestRectangleArea.LargestRectangleArea2(A.ToArr());
        Assert.Equal(expected, actual);
    }
}
