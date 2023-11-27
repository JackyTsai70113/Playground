namespace playground.UnitTest;

public class ThirdMaxTest_0414
{
    [Theory]
    [InlineData("[3,2,1]", 1)]
    [InlineData("[1,2]", 2)]
    [InlineData("[4,3,1,2]", 2)]
    [InlineData("[2,2,3,1]", 1)]
    [InlineData("[5,2,2]", 5)]
    [InlineData("[1,2,-2147483648]", -2147483648)]
    public void ThirdMax(string nums, int expected)
    {
        var actual = ThirdMax_0414.ThirdMax(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
