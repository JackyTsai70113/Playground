namespace playground.UnitTest;

public class DoesAliceWinTest3227
{
    [Theory]
    [InlineData("leetcoder", true)]
    [InlineData("bbcd", false)]
    public void DoesAliceWin(string s, bool expected)
    {
        var actual = new DoesAliceWin3227().DoesAliceWin(s);
        Assert.Equal(expected, actual);
    }
}
