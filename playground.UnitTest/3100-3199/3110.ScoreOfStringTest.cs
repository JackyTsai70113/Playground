namespace playground.UnitTest;

public class ScoreOfStringTest3110
{
    [Theory]
    [InlineData("hello", 13)]
    [InlineData("zaz", 50)]
    public void ScoreOfString(string s, int expected)
    {
        var actual = ScoreOfString3110.ScoreOfString(s);
        Assert.Equal(expected, actual);
    }
}
