namespace playground.UnitTest;

public class LongestConsecutiveTest_0128
{
    [Theory]
    [InlineData("[100,4,200,1,3,2]", 4)]
    [InlineData("[0,3,7,2,5,8,4,6,0,1]", 9)]
    public void LongestConsecutive(string nums, int expected)
    {
        var actual = LongestConsecutive_128.LongestConsecutive(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
