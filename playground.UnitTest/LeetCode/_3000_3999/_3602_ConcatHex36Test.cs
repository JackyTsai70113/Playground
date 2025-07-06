using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3602_ConcatHex36Test
{
    [Theory]
    [InlineData(1, "11")]
    [InlineData(2, "48")]
    [InlineData(3, "9R")]
    [InlineData(4, "101S")]
    [InlineData(5, "193H")]
    [InlineData(13, "A91P1")]
    [InlineData(36, "5101000")]
    public void ConcatHex36(int n, string expected)
    {
        var actual = _3602_ConcatHex36.ConcatHex36(n);
        Assert.Equal(expected, actual);
    }
}
