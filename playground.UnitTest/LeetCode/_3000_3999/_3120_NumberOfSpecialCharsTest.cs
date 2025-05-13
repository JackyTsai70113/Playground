using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3120_NumberOfSpecialCharsTest
{
    [Theory]
    [InlineData("aaAbcBC", 3)]
    [InlineData("abc", 0)]
    [InlineData("abBCab", 1)]
    public void NumberOfSpecialChars(string word, int expected)
    {
        var actual = _3120_NumberOfSpecialChars.NumberOfSpecialChars(word);
        Assert.Equal(expected, actual);
    }
}
