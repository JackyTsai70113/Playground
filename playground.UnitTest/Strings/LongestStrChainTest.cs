using playground.Strings;

namespace playground.UnitTest.Strings;

public class LongestStrChainTest
{
    [Theory]
    [InlineData(new string[] { "a", "b", "ba", "bca", "bda", "bdca" }, 4)]
    [InlineData(new string[] { "xbc", "pcxbcf", "xb", "cxbc", "pcxbc" }, 5)]
    [InlineData(new string[] { "abcd", "dbqca" }, 1)]
    public void LongestStrChain(string[] words, int expected)
    {
        var actual = LongestStrChainClass.LongestStrChain(words);
        Assert.Equal(expected, actual);
    }
}
