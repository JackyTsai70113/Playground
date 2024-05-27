namespace playground.UnitTest;

public class CompressedStringTest3163
{
    [Theory]
    [InlineData("abcde", "1a1b1c1d1e")]
    [InlineData("aaaaaaaaaaaaaabb", "9a5a2b")]
    public void CompressedString(string word, string expected)
    {
        var actual = CompressedString3163.CompressedString(word);
        Assert.Equal(expected, actual);
    }
}
