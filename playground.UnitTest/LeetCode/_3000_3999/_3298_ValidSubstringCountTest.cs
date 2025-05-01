namespace playground.UnitTest;

public class _3298_ValidSubstringCountTest
{
    [Theory]
    [InlineData("bcca", "abc", 1)]
    [InlineData("abcabc", "abc", 10)]
    [InlineData("abcabc", "aaabc", 0)]
    public void ValidSubstringCount(string w1, string w2, int expected)
    {
        var actual = _3298_ValidSubstringCount.ValidSubstringCount(w1, w2);
        Assert.Equal(expected, actual);
    }
}
