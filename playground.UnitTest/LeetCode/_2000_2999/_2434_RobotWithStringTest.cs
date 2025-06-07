using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2434_RobotWithStringTest
{
    [Theory]
    [InlineData("zza", "azz")]
    [InlineData("bac", "abc")]
    [InlineData("bdda", "addb")]
    [InlineData("vzhofnpo", "fnohopzv")]
    [InlineData("mmuqezwmomeplrtskz", "eekstrlpmomwzqummz")]
    public void RobotWithString(string s, string expected)
    {
        var actual = _2434_RobotWithString.RobotWithString(s);
        Assert.Equal(expected, actual);
    }
}
