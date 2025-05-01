using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2781_LongestValidSubstringTest
{
    [Theory]
    [InlineData("cbaaaabc", new string[] { "aaa", "cb" }, 4)]
    [InlineData("leetcode", new string[] { "de", "le", "e" }, 4)]
    public void LongestValidSubstring(string word, IList<string> forbidden, int expected)
    {
        var actual = _2781_LongestValidSubstring.LongestValidSubstring(word, forbidden);
        Assert.Equal(expected, actual);
    }
}
