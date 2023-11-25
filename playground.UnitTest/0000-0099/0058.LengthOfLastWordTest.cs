namespace playground.UnitTest;

public class LengthOfLastWordTest_0058
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    public void LengthOfLastWord(string s, int expected)
    {
        var actual = LengthOfLastWord_0058.LengthOfLastWord(s);
        Assert.Equal(expected, actual);
    }
}
