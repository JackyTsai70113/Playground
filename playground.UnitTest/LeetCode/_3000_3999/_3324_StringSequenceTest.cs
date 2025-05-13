using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3324_StringSequenceTest
{
    [Theory]
    [InlineData("abc", new string[] { "a", "aa", "ab", "aba", "abb", "abc" })]
    [InlineData("he", new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "ha", "hb", "hc", "hd", "he" })]
    public void StringSequence(string target, string[] expected)
    {
        var actual = _3324_StringSequence.StringSequence(target);
        Assert.Equal(expected, actual);
    }
}
