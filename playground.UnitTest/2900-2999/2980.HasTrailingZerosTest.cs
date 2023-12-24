namespace playground.UnitTest;

public class HasTrailingZerosTest2980
{
    [Theory]
    [InlineData("[1,2,3,4,5]", true)]
    [InlineData("[2,4,8,16]", true)]
    [InlineData("[13,5,7,9]", false)]
    public void HasTrailingZeros(string nums, bool expected)
    {
        var actual = HasTrailingZeros2980.HasTrailingZeros(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
