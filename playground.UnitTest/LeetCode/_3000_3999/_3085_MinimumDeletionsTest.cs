namespace playground.UnitTest;

public class _3085_MinimumDeletionsTest
{
    [Theory]
    [InlineData("aabb", 0, 0)]
    [InlineData("aabcaba", 0, 3)]
    [InlineData("dabdcbdcdcd", 2, 2)]
    [InlineData("aaabaaa", 2, 1)]
    [InlineData("zzfzzzzppfp", 1, 3)]
    [InlineData("eenuuuzzzzzz", 0, 6)]
    public void MinimumDeletions(string word, int k, int expected)
    {
        var actual = _3085_MinimumDeletions.MinimumDeletions(word, k);
        Assert.Equal(expected, actual);
    }
}
