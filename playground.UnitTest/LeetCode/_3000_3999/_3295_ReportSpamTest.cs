namespace playground.UnitTest.LeetCode._3000_3999;

public class _3295_ReportSpamTest
{
    [Theory]
    [InlineData(new string[] { "hello", "world", "leetcode" }, new string[] { "world", "hello" }, true)]
    [InlineData(new string[] { "hello", "programming", "fun" }, new string[] { "world", "programming", "leetcode" }, false)]
    public void ReportSpam(string[] message, string[] bannedWords, bool expected)
    {
        var actual = _3295_ReportSpam.ReportSpam(message, bannedWords);
        Assert.Equal(expected, actual);
    }
}
