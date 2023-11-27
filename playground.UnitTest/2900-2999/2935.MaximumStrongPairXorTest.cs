namespace playground.UnitTest;

public class MaximumStrongPairXorTest_2935
{
    [Theory]
    [InlineData("[1,2,3,4,5]", 7)]
    [InlineData("[10,100]", 0)]
    [InlineData("[5,6,25,30]", 7)]
    [InlineData("[500,520,2500,3000]", 1020)]
    public void MaximumStrongPairXor(string nums, int expected)
    {
        var actual = MaximumStrongPairXor_2935.MaximumStrongPairXor(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}