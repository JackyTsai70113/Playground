namespace playground.UnitTest;

public class FindWordsContainingTest_2942
{
    [Theory]
    [InlineData(new string[] { "leet", "code" }, 'e', "[0,1]")]
    [InlineData(new string[] { "abc", "bcd", "aaaa", "cbc" }, 'a', "[0,2]")]
    [InlineData(new string[] { "abc", "bcd", "aaaa", "cbc" }, 'z', "[]")]
    public void FindWordsContaining(string[] A, char x, string expected)
    {
        var actual = FindWordsContaining_2942.FindWordsContaining(A, x);
        Assert.True(Enumerable.SequenceEqual(expected.ToArr(), actual));
    }
}
