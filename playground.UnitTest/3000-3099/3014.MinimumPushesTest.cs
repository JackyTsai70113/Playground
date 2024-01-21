namespace playground.UnitTest;

public class MinimumPushesTest3014
{
    [Theory]
    [InlineData("abcde", 5)]
    [InlineData("xycdefghij", 12)]
    public void MinimumPushes(string word, int expected)
    {
        var actual = MinimumPushes3014.MinimumPushes(word);
        Assert.Equal(expected, actual);
    }
}
