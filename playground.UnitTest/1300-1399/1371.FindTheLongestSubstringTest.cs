namespace playground.UnitTest;

public class FindTheLongestSubstringTest1371
{
    [Theory]
    [InlineData("eleetminicoworoep", 13)]
    [InlineData("leetcodeisgreat", 5)]
    [InlineData("bcbcbcu", 6)]
    public void FindTheLongestSubstring(string s, int expected)
    {
        var actual = FindTheLongestSubstring1371.FindTheLongestSubstring(s);
        Assert.Equal(expected, actual);
    }
}
