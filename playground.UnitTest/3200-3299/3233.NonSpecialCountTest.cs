namespace playground.UnitTest;

public class NonSpecialCountTest3233
{
    [Theory]
    [InlineData(5, 7, 3)]
    [InlineData(4, 16, 11)]
    public void NonSpecialCount(int l, int r, int expected)
    {
        var actual = NonSpecialCount3233.NonSpecialCount(l, r);
        Assert.Equal(expected, actual);
    }
}
