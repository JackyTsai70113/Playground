using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0730_CountPalindromicSubsequencesTest
{
    [Theory]
    [InlineData("bccb", 6)]
    [InlineData("abcdabcdabcdabcdabcdabcdabcdabcddcbadcbadcbadcbadcbadcbadcbadcba", 104860361)]
    [InlineData("dddcabadcbabccdadccbcabcdacdadcbbbcadaabcddccbcadaddbdbdacbcccddabbbcbcdccdaadabadacacbdbbbadcdaaabb", 539524363)]
    public void CountPalindromicSubsequences(string s, int expected)
    {
        var actual = _0730_CountPalindromicSubsequences.CountPalindromicSubsequences(s);
        Assert.Equal(expected, actual);
    }
}
