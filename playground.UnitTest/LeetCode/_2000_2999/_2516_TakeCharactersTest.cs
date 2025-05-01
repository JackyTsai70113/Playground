using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2516_TakeCharactersTest
{
    [Theory]
    [InlineData("aabaaaacaabc", 2, 8)]
    [InlineData("a", 1, -1)]
    [InlineData("a", 0, 0)]
    public void TakeCharacters(string s, int k, int expected)
    {
        var actual = _2516_TakeCharacters.TakeCharacters(s, k);
        Assert.Equal(expected, actual);
    }
}
