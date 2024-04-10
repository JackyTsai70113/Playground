namespace playground.UnitTest;

public class FindKthBitTest1545
{
    [Theory]
    [InlineData(1, 1, '0')]
    [InlineData(3, 1, '0')]
    [InlineData(4, 7, '1')]
    [InlineData(4, 8, '1')]
    [InlineData(4, 12, '0')]
    public void FindKthBit(int n, int k, char expected)
    {
        var actual = FindKthBit1545.FindKthBit(n, k);
        Assert.Equal(expected, actual);
    }
}
