namespace playground.UnitTest;

public class ReversePrefixTest2000
{
    [Theory]
    [InlineData("abcdefd", 'd', "dcbaefd")]
    [InlineData("xyxzxe", 'z', "zxyxxe")]
    [InlineData("abcd", 'z', "abcd")]
    public void ReversePrefix(string word, char ch, string expected)
    {
        var actual = ReversePrefix2000.ReversePrefix(word, ch);
        Assert.Equal(expected, actual);
    }
}
