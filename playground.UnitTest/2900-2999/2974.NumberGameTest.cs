namespace playground.UnitTest;

public class NumberGameTest2974
{
    [Theory]
    [InlineData("[5,4,2,3]", "[3,2,5,4]")]
    [InlineData("[2,5]", "[5,2]")]
    public void NumberGame(string nums, string expected)
    {
        var actual = NumberGame2974.NumberGame(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
