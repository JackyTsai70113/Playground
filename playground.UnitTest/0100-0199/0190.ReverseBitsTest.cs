namespace playground.UnitTest;

public class ReverseBitsTest0190
{
    [Theory]
    [InlineData(43261596, 964176192)]
    [InlineData(4294967293, 3221225471)]
    public void ReverseBits(uint n, uint expected)
    {
        var actual = ReverseBits0190.ReverseBits(n);
        Assert.Equal(expected, actual);
    }
}
