using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3412_CalculateScoreTest
{
    [Theory]
    [InlineData("aczzx", 5)]
    [InlineData("abcdef", 0)]
    [InlineData("zadavyayobbgqsexaabk", 18)]
    [InlineData("eockppxdqclkhjgvnw", 50)]
    public void MinStartingIndex(string s, long expected)
    {
        var actual = _3412_CalculateScore.CalculateScore(s);
        Assert.Equal(expected, actual);
    }
}
