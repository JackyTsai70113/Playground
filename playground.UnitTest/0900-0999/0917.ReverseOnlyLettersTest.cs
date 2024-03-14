namespace playground.UnitTest;

public class ReverseOnlyLettersTest0917
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
        var actual = new ReverseOnlyLetters0917().ReverseOnlyLetters(s);
        Assert.Equal(expected, actual);
    }
}
