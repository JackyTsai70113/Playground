using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2024_MaxConsecutiveAnswersTest
{
    [Theory]
    [InlineData("TTFF", 2, 4)]
    [InlineData("TFFT", 1, 3)]
    [InlineData("TTFTTFTT", 1, 5)]
    public void MaxConsecutiveAnswers(string s, int k, int expected)
    {
        var actual = _2024_MaxConsecutiveAnswers.MaxConsecutiveAnswers(s, k);
        Assert.Equal(expected, actual);
    }
}
