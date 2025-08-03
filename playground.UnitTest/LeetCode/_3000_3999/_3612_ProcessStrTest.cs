using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3612_ProcessStrTest
{

    // test _3612_ProcessStr.ProcessStr
    [Theory]
    [InlineData("a#b%*", "ba")]
    [InlineData("z*#", "")]
    public void ProcessStr(string s, string expected)
    {
        var actual = _3612_ProcessStr.ProcessStr(s);
        Assert.Equal(expected, actual);
    }
}
