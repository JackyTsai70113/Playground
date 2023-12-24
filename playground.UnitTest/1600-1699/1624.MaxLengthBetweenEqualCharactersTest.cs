namespace playground.UnitTest;

public class MaxLengthBetweenEqualCharactersTest1624
{
    [Theory]
    [InlineData("aa", 0)]
    [InlineData("abca", 2)]
    [InlineData("cbzxy", -1)]
    public void MaxLengthBetweenEqualCharacters(string s, int expected)
    {
        var actual = MaxLengthBetweenEqualCharacters1624.MaxLengthBetweenEqualCharacters(s);
        Assert.Equal(expected, actual);
    }
}
