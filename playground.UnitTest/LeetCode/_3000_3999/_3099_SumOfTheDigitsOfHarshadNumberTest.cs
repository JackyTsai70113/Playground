namespace playground.UnitTest;

public class _3099_SumOfTheDigitsOfHarshadNumberTest
{
    [Theory]
    [InlineData(18, 9)]
    [InlineData(23, -1)]
    public void SumOfTheDigitsOfHarshadNumber(int x, int expected)
    {
        var actual = _3099_SumOfTheDigitsOfHarshadNumber.SumOfTheDigitsOfHarshadNumber(x);
        Assert.Equal(expected, actual);
    }
}
