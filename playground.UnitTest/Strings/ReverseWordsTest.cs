using playground.Strings;

namespace playground.UnitTest.Strings;

public class ReverseWordsTest
{
    [Theory]
    [InlineData("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
    [InlineData("God Ding", "doG gniD")]
    public void ReverseWords(string s, string expected)
    {
        var actual = ReverseWordsClass.ReverseWords(s);
        Assert.Equal(expected, actual);
    }
}
