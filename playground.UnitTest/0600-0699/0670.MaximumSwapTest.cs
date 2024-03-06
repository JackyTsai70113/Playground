namespace playground.UnitTest;

public class MaximumSwapTest0670
{
    [Theory]
    [InlineData(2736, 7236)]
    [InlineData(98638, 98836)]
    [InlineData(1992, 9912)]
    public void MaximumSwap(int num, int expected)
    {
        var actual = MaximumSwap0670.MaximumSwap(num);
        Assert.Equal(expected, actual);
    }
}
