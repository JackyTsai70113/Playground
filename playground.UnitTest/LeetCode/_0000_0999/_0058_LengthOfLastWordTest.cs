using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0058_LengthOfLastWordTest
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    public void LengthOfLastWord(string s, int expected)
    {
        var actual = _0058_LengthOfLastWord.LengthOfLastWord(s);
        Assert.Equal(expected, actual);
    }
}
