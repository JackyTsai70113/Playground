using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1737_MinCharactersTest
{
    [Theory]
    [InlineData("aba", "caa", 2)]
    [InlineData("dabadd", "cda", 3)]
    [InlineData("a", "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz", 2)]
    public void MinCharacters(string a, string b, int expected)
    {
        var actual = _1737_MinCharacters.MinCharacters(a, b);
        Assert.Equal(expected, actual);
    }
}
