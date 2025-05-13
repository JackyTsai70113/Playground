namespace playground.UnitTest.LeetCode._3000_3999;

public class _3227_DoesAliceWinTest
{
    [Theory]
    [InlineData("leetcoder", true)]
    [InlineData("bbcd", false)]
    public void DoesAliceWin(string s, bool expected)
    {
        var actual = new _3227_DoesAliceWin().DoesAliceWin(s);
        Assert.Equal(expected, actual);
    }
}
