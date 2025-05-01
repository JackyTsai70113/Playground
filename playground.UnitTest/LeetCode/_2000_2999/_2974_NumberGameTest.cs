using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2974_NumberGameTest
{
    [Theory]
    [InlineData("[5,4,2,3]", "[3,2,5,4]")]
    [InlineData("[2,5]", "[5,2]")]
    public void NumberGame(string nums, string expected)
    {
        var actual = _2974_NumberGame.NumberGame(nums.ToArr());
        Assert.Equal(expected.ToArr(), actual);
    }
}
