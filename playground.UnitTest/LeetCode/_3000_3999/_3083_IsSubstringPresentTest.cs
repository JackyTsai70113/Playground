namespace playground.UnitTest.LeetCode._3000_3999;

public class _3083_IsSubstringPresentTest
{
    [Theory]
    [InlineData("leetcode", true)]
    [InlineData("abcba", true)]
    [InlineData("abcd", false)]
    public void IsSubstringPresent(string s, bool expected)
    {
        var actual = _3083_IsSubstringPresent.IsSubstringPresent(s);
        Assert.Equal(expected, actual);
    }
}
