using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0557_ReverseWordsTest
{
    [Theory]
    [InlineData("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
    [InlineData("God Ding", "doG gniD")]
    public void ReverseWords(string s, string expected)
    {
        var actual = _0557_ReverseWords.ReverseWords(s);
        Assert.Equal(expected, actual);
    }
}
