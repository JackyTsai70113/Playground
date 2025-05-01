using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0917_ReverseOnlyLettersTest
{
    [Theory]
    [InlineData("-b", "-b")]
    [InlineData("ab", "ba")]
    [InlineData("abc", "cba")]
    [InlineData("ab-cd", "dc-ba")]
    [InlineData("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
    [InlineData("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]
    public void ReverseOnlyLetters(string s, string expected)
    {
        var actual = _0917_ReverseOnlyLetters.ReverseOnlyLetters(s);
        Assert.Equal(expected, actual);
    }
}
