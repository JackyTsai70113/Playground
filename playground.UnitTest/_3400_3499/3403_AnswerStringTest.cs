using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

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
