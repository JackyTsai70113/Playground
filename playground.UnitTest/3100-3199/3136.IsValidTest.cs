namespace playground.UnitTest;

public class IsValidTest3136
{
    [Theory]
    [InlineData("234Adas", true)]
    [InlineData("b3", false)]
    [InlineData("a3$e", false)]
    [InlineData("a3eC", true)]
    public void IsValid(string word, bool expected)
    {
        var actual = IsValid3136.IsValid(word);
        Assert.Equal(expected, actual);
    }
}
