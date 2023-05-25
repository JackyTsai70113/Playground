using playground.SlidingWindow;

namespace playground.UnitTest.SlidingWindow;

public class TakeCharactersTest
{
    [Theory]
    [InlineData("aabaaaacaabc", 2, 8)]
    [InlineData("a", 1, -1)]
    [InlineData("a", 0, 0)]
    public void TakeCharacters(string s, int k, int expected)
    {
        var actual = TakeCharactersClass.TakeCharacters(s, k);
        Assert.Equal(expected, actual);
    }
}
