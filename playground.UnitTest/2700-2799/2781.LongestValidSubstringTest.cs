namespace playground.UnitTest;

public class LongestValidSubstringTest2781
{
    [Theory]
    [InlineData("cbaaaabc", new string[] { "aaa", "cb" }, 4)]
    [InlineData("leetcode", new string[] { "de", "le", "e" }, 4)]
    public void LongestValidSubstring(string word, IList<string> forbidden, int expected)
    {
        var actual = LongestValidSubstring2781.LongestValidSubstring(word, forbidden);
        Assert.Equal(expected, actual);
    }
}
