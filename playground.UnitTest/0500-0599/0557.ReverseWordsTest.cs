namespace playground.UnitTest;

public class ReverseWordsTest_0557
{
    [Theory]
    [InlineData("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
    [InlineData("God Ding", "doG gniD")]
    public void ReverseWords(string s, string expected)
    {
        var actual = ReverseWords_0557.ReverseWords(s);
        Assert.Equal(expected, actual);
    }
}
