namespace playground.UnitTest;

public class GetSmallestStringTest3216
{
    [Theory]
    [InlineData("45320", "43520")]
    [InlineData("42420", "24420")]
    [InlineData("001", "001")]
    public void GetSmallestString(string s, string expected)
    {
        var actual = new GetSmallestString3216().GetSmallestString(s);
        Assert.Equal(expected, actual);
    }
}
