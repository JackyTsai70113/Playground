using playground.BitManipulation;
namespace playground.UnitTest.BitManipulation;

public class WordCountTest
{
    [Theory]
    [InlineData(new string[] { "ant", "act", "tack" }, new string[] { "tack", "act", "acti" }, 2)]
    [InlineData(new string[] { "ab", "a" }, new string[] { "abc", "abcd" }, 1)]
    [InlineData(new string[] { "ab", "a" }, new string[] { "ab", "a" }, 1)]
    public void WordCount(string[] startWords, string[] targetWords, int expected)
    {
        var actual = WordCountClass.WordCount(startWords, targetWords);
        Assert.Equal(expected, actual);
    }
}
