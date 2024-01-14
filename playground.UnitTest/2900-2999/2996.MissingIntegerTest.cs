namespace playground.UnitTest;

public class MissingIntegerTest2996
{
    [Theory]
    [InlineData("[1,2,3,2,5]", 6)]
    [InlineData("[3,4,5,1,12,14,13]", 15)]
    public void MissingInteger(string nums, int expected)
    {
        var actual = MissingInteger2996.MissingInteger(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
