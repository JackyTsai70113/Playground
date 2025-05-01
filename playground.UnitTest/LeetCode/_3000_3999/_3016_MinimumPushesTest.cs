namespace playground.UnitTest;

public class _3016_MinimumPushesTest
{
    [Theory]
    [InlineData("abcde", 5)]
    [InlineData("xyzxyzxyzxyz", 12)]
    [InlineData("aabbccddeeffgghhiiiiii", 24)]
    public void MinimumPushes(string word, int expected)
    {
        var actual = _3016_MinimumPushes.MinimumPushes(word);
        Assert.Equal(expected, actual);
    }
}
