using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2996_MissingIntegerTest
{
    [Theory]
    [InlineData("[1,2,3,2,5]", 6)]
    [InlineData("[3,4,5,1,12,14,13]", 15)]
    public void MissingInteger(string nums, int expected)
    {
        var actual = _2996_MissingInteger.MissingInteger(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
