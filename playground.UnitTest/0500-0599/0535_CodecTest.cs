using playground._0500_0599;

namespace playground.UnitTest._0500_0599;

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
