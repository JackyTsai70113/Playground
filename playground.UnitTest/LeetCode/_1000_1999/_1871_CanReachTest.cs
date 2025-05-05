using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1871_CanReachTest
{
    [Theory]
    [InlineData("011010", 2, 3, true)]
    [InlineData("011011", 2, 3, false)]
    [InlineData("01101110", 2, 3, false)]
    [InlineData("00111010", 3, 5, false)]
    public void Test(string s, int minJump, int maxJump, bool expected)
    {
        var result = _1871_CanReach.CanReach(s, minJump, maxJump);
        Assert.Equal(expected, result);
    }
}
