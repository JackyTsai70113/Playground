namespace playground.UnitTest;

public class _1624_MaxLengthBetweenEqualCharactersTest
{
    [Theory]
    [InlineData("aa", 0)]
    [InlineData("abca", 2)]
    [InlineData("cbzxy", -1)]
    public void MaxLengthBetweenEqualCharacters(string s, int expected)
    {
        var actual = _1624_MaxLengthBetweenEqualCharacters.MaxLengthBetweenEqualCharacters(s);
        Assert.Equal(expected, actual);
    }
}
