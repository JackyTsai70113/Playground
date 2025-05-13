namespace playground.UnitTest.LeetCode._3000_3999;

public class _3012_MinimumArrayLengthTest
{
    [Theory]
    [InlineData("[1,4,3,1]", 1)]
    [InlineData("[5,5,5,10,5]", 2)]
    [InlineData("[2,3,4]", 1)]
    [InlineData("[3,3,1]", 1)]
    [InlineData("[5,2,2,2,9,10]", 1)]
    public void MinimumArrayLength(string nums, int expected)
    {
        var actual = _3012_MinimumArrayLength.MinimumArrayLength(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
