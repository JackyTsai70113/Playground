namespace playground.UnitTest;

public class SingleNumberTest0136
{
    [Theory]
    [InlineData("[2,2,1]", 1)]
    [InlineData("[4,1,2,1,2]", 4)]
    [InlineData("[1]", 1)]
    public void SingleNumber(string nums, int expected)
    {
        var actual = SingleNumber0136.SingleNumber(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
