namespace playground.UnitTest;

public class FirstUniqCharTest0387
{
    [Theory]
    [InlineData("leetcode", 0)]
    [InlineData("loveleetcode", 2)]
    [InlineData("aabb", -1)]
    public void FirstUniqChar(string s, int expected)
    {
        var actual = FirstUniqChar0387.FirstUniqChar(s);
        Assert.Equal(expected, actual);
    }
}
