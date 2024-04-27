namespace playground.UnitTest;

public class CountPalindromicSubsequencesTest0730
{
    [Theory]
    [InlineData("bccb", 6)]
    [InlineData("abcdabcdabcdabcdabcdabcdabcdabcddcbadcbadcbadcbadcbadcbadcbadcba", 104860361)]
    [InlineData("dddcabadcbabccdadccbcabcdacdadcbbbcadaabcddccbcadaddbdbdacbcccddabbbcbcdccdaadabadacacbdbbbadcdaaabb", 539524363)]
    public void CountPalindromicSubsequences(string s, int expected)
    {
        var actual = CountPalindromicSubsequences0730.CountPalindromicSubsequences(s);
        Assert.Equal(expected, actual);
    }
}
