namespace playground.UnitTest.LeetCode._3000_3999;

public class _3163_CompressedStringTest
{
    [Theory]
    [InlineData("abcde", "1a1b1c1d1e")]
    [InlineData("aaaaaaaaaaaaaabb", "9a5a2b")]
    public void CompressedString(string word, string expected)
    {
        var actual = _3163_CompressedString.CompressedString(word);
        Assert.Equal(expected, actual);
    }
}
