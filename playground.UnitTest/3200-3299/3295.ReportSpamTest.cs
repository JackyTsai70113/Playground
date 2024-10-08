namespace playground.UnitTest;

public class ReportSpamTest3295
{
    [Theory]
    [InlineData(new string[] { "hello", "world", "leetcode" }, new string[] { "world", "hello" }, true)]
    [InlineData(new string[] { "hello", "programming", "fun" }, new string[] { "world", "programming", "leetcode" }, false)]
    public void ReportSpam(string[] message, string[] bannedWords, bool expected)
    {
        var actual = ReportSpam3295.ReportSpam(message, bannedWords);
        Assert.Equal(expected, actual);
    }
}
