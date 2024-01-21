namespace playground.UnitTest;

public class RobTest0198
{
    [Theory]
    [InlineData("[1,2,3,1]", 4)]
    [InlineData("[2,7,9,3,1]", 12)]
    [InlineData("[2,1,1,2]", 4)]
    public void Rob(string nums, int expected)
    {
        var actual = Rob0198.Rob(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
