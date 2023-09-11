using playground.SlidingWindow;

namespace playground.UnitTest.SlidingWindow;

public class LongestValidSubstringTest
{
    [Theory]
    [InlineData("cbaaaabc", new string[] { "aaa", "cb" }, 4)]
    [InlineData("leetcode", new string[] { "de", "le", "e" }, 4)]
    public void LongestValidSubstring(string word, IList<string> forbidden, int expected)
    {
        var actual = LongestValidSubstringClass.LongestValidSubstring(word, forbidden.ToList());
        Assert.Equal(expected, actual);
    }
}
