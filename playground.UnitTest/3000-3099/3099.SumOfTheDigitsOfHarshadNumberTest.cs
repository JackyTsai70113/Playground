namespace playground.UnitTest;

public class SumOfTheDigitsOfHarshadNumberTest3099
{
    [Theory]
    [InlineData(18, 9)]
    [InlineData(23, -1)]
    public void SumOfTheDigitsOfHarshadNumber(int x, int expected)
    {
        var actual = SumOfTheDigitsOfHarshadNumber3099.SumOfTheDigitsOfHarshadNumber(x);
        Assert.Equal(expected, actual);
    }
}
