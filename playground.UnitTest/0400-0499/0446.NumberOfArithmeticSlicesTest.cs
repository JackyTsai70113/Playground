namespace playground.UnitTest;

public class NumberOfArithmeticSlicesTest0446
{
    [Theory]
    [InlineData("[2,4,6,8]", 3)]
    [InlineData("[2,4,6,8,10]", 7)]
    [InlineData("[7,7,7,7,7]", 16)]
    [InlineData("[0,2000000000,-294967296]", 0)]
    public void NumberOfArithmeticSlices(string nums, int expected)
    {
        var actual = NumberOfArithmeticSlices0446.NumberOfArithmeticSlices(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
