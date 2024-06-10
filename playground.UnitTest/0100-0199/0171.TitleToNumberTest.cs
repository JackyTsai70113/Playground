namespace playground.UnitTest;

public class TitleToNumberTest0171
{
    [Theory]
    [InlineData("A", 1)]
    [InlineData("AB", 28)]
    [InlineData("ZY", 701)]
    public void TitleToNumber(string A, int expected)
    {
        var actual = TitleToNumber0171.TitleToNumber(A);
        Assert.Equal(expected, actual);
    }
}
