namespace playground.UnitTest;

public class MySqrtTest0069
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(4, 2)]
    [InlineData(8, 2)]
    [InlineData(124314239, 11149)]
    public void MySqrt(int x, int expected)
    {
        var actual = MySqrt0069.MySqrt(x);
        Assert.Equal(expected, actual);
    }
}
