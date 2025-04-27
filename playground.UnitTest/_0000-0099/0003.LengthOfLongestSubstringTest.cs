namespace playground.UnitTest;

public class LengthOfLongestSubstringTest0003
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData(" ", 1)]
    public void LengthOfLongestSubstring(string s, int expected)
    {
        var actual = _0003_LengthOfLongestSubstring.LengthOfLongestSubstring(s);
        Assert.Equal(expected, actual);
    }
}
