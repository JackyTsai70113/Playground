namespace playground.UnitTest;

public class GetSumTest0371
{
    [Theory]
    [InlineData(-1, 1, 0)]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    public void GetSum(int a, int b, int expected)
    {
        var actual = GetSum0371.GetSum(a, b);
        Assert.Equal(expected, actual);
    }
}
