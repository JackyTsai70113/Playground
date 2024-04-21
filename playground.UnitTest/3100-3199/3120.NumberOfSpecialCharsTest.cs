namespace playground.UnitTest;

public class NumberOfSpecialCharsTest3120
{
    [Theory]
    [InlineData("aaAbcBC", 3)]
    [InlineData("abc", 0)]
    [InlineData("abBCab", 1)]
    public void NumberOfSpecialChars(string word, int expected)
    {
        var actual = NumberOfSpecialChars3120.NumberOfSpecialChars(word);
        Assert.Equal(expected, actual);
    }
}
