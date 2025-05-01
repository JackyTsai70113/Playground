using playground.LeetCode._0000_0999;

namespace playground.UnitTest.LeetCode._0000_0999;

public class _0190_ReverseBitsTest
{
    [Theory]
    [InlineData(43261596, 964176192)]
    [InlineData(4294967293, 3221225471)]
    public void ReverseBits(uint n, uint expected)
    {
        var actual = _0190_ReverseBits.ReverseBits(n);
        Assert.Equal(expected, actual);
    }
}
