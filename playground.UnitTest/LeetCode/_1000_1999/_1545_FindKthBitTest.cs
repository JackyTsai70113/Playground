namespace playground.UnitTest;

public class _1545_FindKthBitTest
{
    [Theory]
    [InlineData(1, 1, '0')]
    [InlineData(3, 1, '0')]
    [InlineData(4, 7, '1')]
    [InlineData(4, 8, '1')]
    [InlineData(4, 12, '0')]
    public void FindKthBit(int n, int k, char expected)
    {
        var actual = _1545_FindKthBit.FindKthBit(n, k);
        Assert.Equal(expected, actual);
    }
}
