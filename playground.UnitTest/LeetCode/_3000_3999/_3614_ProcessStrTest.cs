using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3614_ProcessStrTest
{
    [Theory]
    [InlineData("a#b%*", 1, 'a')]
    [InlineData("cd%#*#", 3, 'd')]
    [InlineData("z*#", 0, '.')]
    public void ProcessStr(string s, long k, char expected)
    {
        var actual = _3614_ProcessStr.ProcessStr(s, k);
        Assert.Equal(expected, actual);
    }
}
