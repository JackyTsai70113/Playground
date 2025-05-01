using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0446_NumberOfArithmeticSlicesTest
{
    [Theory]
    [InlineData("[2,4,6,8]", 3)]
    [InlineData("[2,4,6,8,10]", 7)]
    [InlineData("[7,7,7,7,7]", 16)]
    [InlineData("[0,2000000000,-294967296]", 0)]
    public void NumberOfArithmeticSlices(string nums, int expected)
    {
        var actual = _0446_NumberOfArithmeticSlices.NumberOfArithmeticSlices(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
