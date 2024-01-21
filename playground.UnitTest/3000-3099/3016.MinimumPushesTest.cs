namespace playground.UnitTest;

public class MinimumPushesTest3016
{
    [Theory]
    [InlineData("abcde", 5)]
    [InlineData("xyzxyzxyzxyz", 12)]
    [InlineData("aabbccddeeffgghhiiiiii", 24)]
    public void MinimumPushes(string word, int expected)
    {
        var actual = MinimumPushes3016.MinimumPushes(word);
        Assert.Equal(expected, actual);
    }
}
