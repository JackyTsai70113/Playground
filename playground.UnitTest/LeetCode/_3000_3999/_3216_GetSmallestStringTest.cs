using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3216_GetSmallestStringTest
{
    [Theory]
    [InlineData("45320", "43520")]
    [InlineData("42420", "24420")]
    [InlineData("001", "001")]
    public void GetSmallestString(string s, string expected)
    {
        var actual = _3216_GetSmallestString.GetSmallestString(s);
        Assert.Equal(expected, actual);
    }
}
