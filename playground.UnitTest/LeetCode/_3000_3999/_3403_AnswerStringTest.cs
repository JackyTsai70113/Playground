using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3403_AnswerStringTest
{
    [Theory]
    [InlineData("dbca", 2, "dbc")]
    [InlineData("gggg", 4, "g")]
    [InlineData("aann", 2, "nn")]
    [InlineData("gh", 1, "gh")]
    [InlineData("dah", 3, "h")]
    [InlineData("nbjnc", 2, "nc")]
    public void MinStartingIndex(string word, int numFriends, string expected)
    {
        var actual = _3403_AnswerString.AnswerString(word, numFriends);
        Assert.Equal(expected, actual);
    }
}
