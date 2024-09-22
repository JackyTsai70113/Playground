using System;
using playground._2000_2099;

namespace playground.UnitTest._2000_2099;

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
