using playground.Greedy;

namespace playground.UnitTest.Greedy;

public class MinimizeConcatenatedLengthTest
{
    [Theory]
    [InlineData(new string[] { "aa", "ab", "bc" }, 4)]
    [InlineData(new string[] { "ab", "b" }, 2)]
    [InlineData(new string[] { "aaa", "c", "aba" }, 6)]
    public void MinimizeConcatenatedLength(string[] words, int expected)
    {
        var actual = MinimizeConcatenatedLengthClass.MinimizeConcatenatedLength(words);
        Assert.Equal(expected, actual);
    }
}
