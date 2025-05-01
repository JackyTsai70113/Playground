using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0535_CodecTest
{
    [Theory]
    [InlineData("https://leetcode.com/problems/design-tinyurl", "https://leetcode.com/problems/design-tinyurl")]
    public void Codec(string longUrl, string expected)
    {
        var obj = new _0535_Codec();
        Assert.Equal(expected, obj.decode(obj.encode(longUrl)));
    }
}
