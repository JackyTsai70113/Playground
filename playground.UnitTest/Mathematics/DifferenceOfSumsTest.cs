namespace playground.UnitTest;

public class DifferenceOfSumsTest
{
    [Theory]
    [InlineData(10, 3, 19)]
    [InlineData(5, 6, 15)]
    [InlineData(5, 1, -15)]
    public void DifferenceOfSums(int n, int m, int expected)
    {
        var actual = DifferenceOfSumsClass.DifferenceOfSums(n, m);
        Assert.Equal(expected, actual);
    }
}
