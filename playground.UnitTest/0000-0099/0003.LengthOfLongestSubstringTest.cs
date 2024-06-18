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
        var actual = LengthOfLongestSubstring0003.LengthOfLongestSubstring(s);
        Assert.Equal(expected, actual);
    }
}
