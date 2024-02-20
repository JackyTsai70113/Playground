namespace playground.UnitTest;

public class LengthOfLISTest0300
{
    [Theory]
    [InlineData("[10,9,2,5,3,7,101,18]", 4)]
    [InlineData("[0,1,0,3,2,3]", 4)]
    [InlineData("[7,7,7,7,7,7,7]", 1)]
    public void MaxSlidingWindow(string nums, int expected)
    {
        var actual = LengthOfLIS0300.LengthOfLIS(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
