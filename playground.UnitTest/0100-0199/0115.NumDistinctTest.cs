namespace playground.UnitTest;

public class NumDistinctTest0115
{
    [Theory]
    [InlineData("rabbbit", "rabbit", 3)]
    [InlineData("babgbag", "bag", 5)]
    [InlineData("ababgbag", "bag", 5)]
    public void NumDistinct(string s, string t, int expected)
    {
        var actual = NumDistinct0115.NumDistinct(s, t);
        Assert.Equal(expected, actual);
    }
}
