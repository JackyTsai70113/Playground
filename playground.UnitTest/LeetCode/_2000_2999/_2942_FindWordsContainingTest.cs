using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2942_FindWordsContainingTest
{
    [Theory]
    [InlineData(new string[] { "leet", "code" }, 'e', "[0,1]")]
    [InlineData(new string[] { "abc", "bcd", "aaaa", "cbc" }, 'a', "[0,2]")]
    [InlineData(new string[] { "abc", "bcd", "aaaa", "cbc" }, 'z', "[]")]
    public void FindWordsContaining(string[] A, char x, string expected)
    {
        var actual = _2942_FindWordsContaining.FindWordsContaining(A, x);
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }
}
