using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0053_MaxSubArrayTest
{
    [Theory]
    [InlineData("[-2,1,-3,4,-1,2,1,-5,4]", 6)]
    [InlineData("[1]", 1)]
    [InlineData("[5,4,-1,7,8]", 23)]
    [InlineData("[-5,-1,-7,-8]", -1)]
    public void MaxSubArray(string A, int expected)
    {
        var actual = _0053_MaxSubArray.MaxSubArray(A.ToArr());
        Assert.Equal(expected, actual);
        var actual2 = _0053_MaxSubArray.MaxSubArray2(A.ToArr());
        Assert.Equal(expected, actual2);
    }
}
