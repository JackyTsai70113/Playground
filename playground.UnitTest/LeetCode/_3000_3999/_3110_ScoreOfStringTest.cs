namespace playground.UnitTest.LeetCode._3000_3999;

public class _3110_ScoreOfStringTest
{
    [Theory]
    [InlineData("hello", 13)]
    [InlineData("zaz", 50)]
    public void ScoreOfString(string s, int expected)
    {
        var actual = _3110_ScoreOfString.ScoreOfString(s);
        Assert.Equal(expected, actual);
    }
}
