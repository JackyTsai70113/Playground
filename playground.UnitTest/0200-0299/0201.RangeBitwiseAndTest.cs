namespace playground.UnitTest;

public class RangeBitwiseAndTest0201
{
    [Theory]
    [InlineData(5, 7, 4)]
    [InlineData(0, 0, 0)]
    [InlineData(1, 2147483647, 0)]
    [InlineData(1073741824, 2147483647, 1073741824)]
    public void RangeBitwiseAnd(int left, int right, int expected)
    {
        var actual = RangeBitwiseAnd0201.RangeBitwiseAnd(left, right);
        Assert.Equal(expected, actual);
    }
}
