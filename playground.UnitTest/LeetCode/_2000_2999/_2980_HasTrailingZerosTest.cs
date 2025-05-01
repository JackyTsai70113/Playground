using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2980_HasTrailingZerosTest
{
    [Theory]
    [InlineData("[1,2,3,4,5]", true)]
    [InlineData("[2,4,8,16]", true)]
    [InlineData("[13,5,7,9]", false)]
    public void HasTrailingZeros(string nums, bool expected)
    {
        var actual = _2980_HasTrailingZeros.HasTrailingZeros(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
