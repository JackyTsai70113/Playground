namespace playground.UnitTest.LeetCode._3000_3999;

public class _3014_MinimumPushesTest
{
    [Theory]
    [InlineData("abcde", 5)]
    [InlineData("xycdefghij", 12)]
    public void MinimumPushes(string word, int expected)
    {
        var actual = _3014_MinimumPushes.MinimumPushes(word);
        Assert.Equal(expected, actual);
    }
}
