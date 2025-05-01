using playground._3400_3499;

namespace playground.UnitTest._3400_3499;

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
