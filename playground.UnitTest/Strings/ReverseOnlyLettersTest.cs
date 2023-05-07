using playground.Strings;

namespace playground.UnitTest.Strings;

public class ReverseOnlyLettersTest
{
    [Theory]
    [InlineData("ab-cd", "dc-ba")]
    [InlineData("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
    [InlineData("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]
    public void ReverseOnlyLetters(string s, string expected)
    {
        var actual = ReverseOnlyLettersClass.ReverseOnlyLetters(s);
        Assert.Equal(expected, actual);
    }
}
