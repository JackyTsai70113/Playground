namespace playground.UnitTest;

public class SumSubarrayMinsTest0907
{
    [Theory]
    [InlineData("[3,1,2,4]", 17)]
    [InlineData("[11,81,94,43,3]", 444)]
    public void SumSubarrayMins(string nums, int expected)
    {
        var actual = SumSubarrayMins0907.SumSubarrayMins(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
