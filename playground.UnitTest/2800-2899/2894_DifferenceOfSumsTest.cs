using playground._2800_2899;

namespace playground.UnitTest._2800_2899;

public class _2894_DifferenceOfSumsTest
{
    [Theory]
    [InlineData(10, 3, 19)]
    [InlineData(5, 6, 15)]
    [InlineData(5, 1, -15)]
    public void DifferenceOfSums(int n, int m, int expected)
    {
        var actual = _2894_DifferenceOfSums.DifferenceOfSums(n, m);
        Assert.Equal(expected, actual);
    }
}
