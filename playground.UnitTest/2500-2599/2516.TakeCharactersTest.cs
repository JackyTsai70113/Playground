namespace playground.UnitTest;

public class TakeCharactersTest2516
{
    [Theory]
    [InlineData("aabaaaacaabc", 2, 8)]
    [InlineData("a", 1, -1)]
    [InlineData("a", 0, 0)]
    public void TakeCharacters(string s, int k, int expected)
    {
        var actual = TakeCharacters2516.TakeCharacters(s, k);
        Assert.Equal(expected, actual);
    }
}
