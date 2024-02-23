namespace playground.UnitTest;

public class MinWindowTest0076
{
    [Theory]
    [InlineData("ADOBECODEBANC", "ABC", "BANC")]
    [InlineData("CODEBANC", "ABC", "BANC")]
    [InlineData("BANC", "ABC", "BANC")]
    [InlineData("a", "a", "a")]
    [InlineData("a", "aa", "")]
    [InlineData("a", "b", "")]
    public void MinWindow(string s, string t, string expected)
    {
        var actual = MinWindow0076.MinWindow(s, t);
        Assert.Equal(expected, actual);
    }
}
