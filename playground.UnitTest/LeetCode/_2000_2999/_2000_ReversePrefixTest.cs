using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2000_ReversePrefixTest
{
    [Theory]
    [InlineData("abcdefd", 'd', "dcbaefd")]
    [InlineData("xyxzxe", 'z', "zxyxxe")]
    [InlineData("abcd", 'z', "abcd")]
    public void ReversePrefix(string word, char ch, string expected)
    {
        var actual = _2000_ReversePrefix.ReversePrefix(word, ch);
        Assert.Equal(expected, actual);
    }
}
