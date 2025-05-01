using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2825_CanMakeSubsequenceTest_cs
{
    [Theory]
    [InlineData("abc", "ad", true)]
    [InlineData("zc", "ad", true)]
    [InlineData("ab", "d", false)]
    public void CanMakeSubsequence(string str1, string str2, bool expected)
    {
        var actual = _2825_CanMakeSubsequence_cs.CanMakeSubsequence(str1, str2);
        Assert.Equal(expected, actual);
    }
}
