namespace playground.UnitTest;

public class ValidSubstringCountTest3297
{
    [Theory]
    [InlineData("bcca", "abc", 1)]
    [InlineData("abcabc", "abc", 10)]
    [InlineData("abcabc", "aaabc", 0)]
    public void ValidSubstringCount(string w1, string w2, int expected)
    {
        var actual = ValidSubstringCount3297.ValidSubstringCount(w1, w2);
        Assert.Equal(expected, actual);
    }
}