using playground._3300_3399;

namespace playground.UnitTest._3300_3399;

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
