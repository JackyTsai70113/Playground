namespace playground.UnitTest ;

public class EqualSubstringTest1208
{
    [Theory]
    [InlineData("abcd", "bcdf", 3, 3)]
    [InlineData("abcd", "cdef", 3, 1)]
    [InlineData("abcd", "acde", 0, 1)]
    [InlineData("krrgw", "zjxss", 19, 2)]
    public void EqualSubstring(string s, string t, int maxCost, int expected)
    {
        var actual = EqualSubstring1208.EqualSubstring(s, t, maxCost);
        Assert.Equal(expected, actual);
    }
}
