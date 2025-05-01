using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0135_CandyTest
{
    [Theory]
    [InlineData("[1,0,2]", 5)]
    [InlineData("[1,2,2]", 4)]
    public void Candy(string nums, int expected)
    {
        var actual = _0135_Candy.Candy(nums.ToArr());
        Assert.Equal(expected, actual);
    }
}
