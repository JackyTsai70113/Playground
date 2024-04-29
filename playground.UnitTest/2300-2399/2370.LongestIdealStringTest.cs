namespace playground.UnitTest;

public class LongestIdealStringTest2370
{
    [Theory]
    [InlineData("acfgbd", 2, 4)]
    [InlineData("abcd", 3, 4)]
    [InlineData("abcd", 0, 1)]
    [InlineData("azaza", 25, 5)]
    public void LongestIdealString(string s, int k, int expected)
    {
        var actual = LongestIdealString2370.LongestIdealString(s, k);
        Assert.Equal(expected, actual);
    }
}
