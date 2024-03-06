namespace playground.UnitTest;

public class CheckValidStringTest0678
{
    [Theory]
    [InlineData(")", false)]
    [InlineData("()", true)]
    [InlineData("(*)", true)]
    [InlineData("(*))", true)]
    [InlineData("((", false)]
    [InlineData("(***)", true)]
    [InlineData("(((*****", true)]
    [InlineData("(((**", false)]
    public void CheckValidString(string s, bool expected)
    {
        var actual = CheckValidString0678.CheckValidString(s);
        Assert.Equal(expected, actual);
    }
}
