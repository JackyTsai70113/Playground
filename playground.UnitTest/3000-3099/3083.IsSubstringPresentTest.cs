namespace playground.UnitTest;

public class IsSubstringPresentTest3083
{
    [Theory]
    [InlineData("leetcode", true)]
    [InlineData("abcba", true)]
    [InlineData("abcd", false)]
    public void IsSubstringPresent(string s, bool expected)
    {
        var actual = IsSubstringPresent3083.IsSubstringPresent(s);
        Assert.Equal(expected, actual);
    }
}
