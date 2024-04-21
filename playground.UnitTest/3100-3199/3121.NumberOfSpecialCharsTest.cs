namespace playground.UnitTest;

public class NumberOfSpecialCharsTest3121
{
    [Theory]
    [InlineData("aaAbcBC", 3)]
    [InlineData("abc", 0)]
    [InlineData("AbBCab", 0)]
    public void NumberOfSpecialChars(string word, int expected)
    {
        var actual = NumberOfSpecialChars3121.NumberOfSpecialChars(word);
        Assert.Equal(expected, actual);
    }
}
