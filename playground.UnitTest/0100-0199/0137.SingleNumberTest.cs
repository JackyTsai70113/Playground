namespace playground.UnitTest;

public class SingleNumberTest0137
{
    [Theory]
    [InlineData("[2,2,3,2]", 3)]
    [InlineData("[0,1,0,1,0,1,99]", 99)]
    public void SingleNumber(string nums, int expected)
    {
        var actual = SingleNumber0137.SingleNumber(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
