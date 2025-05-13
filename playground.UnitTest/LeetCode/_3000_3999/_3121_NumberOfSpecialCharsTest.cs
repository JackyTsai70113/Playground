namespace playground.UnitTest.LeetCode._3000_3999;

public class _3121_NumberOfSpecialCharsTest
{
    [Theory]
    [InlineData("aaAbcBC", 3)]
    [InlineData("abc", 0)]
    [InlineData("AbBCab", 0)]
    public void NumberOfSpecialChars(string word, int expected)
    {
        var actual = _3121_NumberOfSpecialChars.NumberOfSpecialChars(word);
        Assert.Equal(expected, actual);
    }
}
