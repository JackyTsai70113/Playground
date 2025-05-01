namespace playground.UnitTest;

public class _3136_IsValidTest
{
    [Theory]
    [InlineData("234Adas", true)]
    [InlineData("b3", false)]
    [InlineData("a3$e", false)]
    [InlineData("a3eC", true)]
    public void IsValid(string word, bool expected)
    {
        var actual = _3136_IsValid.IsValid(word);
        Assert.Equal(expected, actual);
    }
}
