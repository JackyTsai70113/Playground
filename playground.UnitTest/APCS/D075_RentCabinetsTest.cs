using playground.APCS;

namespace playground.UnitTest.APCS;

public class D075_RentCabinetsTest
{
    [Theory]
    [InlineData(10, 6, new int[] { 4, 4, 1 }, 5)]
    [InlineData(20, 14, new int[] { 8, 2, 7, 2, 1 }, 15)]
    [InlineData(20, 3, new int[] { 5, 4, 2, 1, 7 }, 2)]
    [InlineData(25, 8, new int[] { 6, 4, 7, 3, 2, 1 }, 6)]
    [InlineData(10, 5, new int[] { 1, 1, 1 }, 0)]
    [InlineData(10, 5, new int[] { 2, 2, 2 }, 2)]
    [InlineData(5, 5, new int[] { 2, 2, 2 }, 6)]
    [InlineData(11, 6, new int[] { 3, 2 }, 0)]
    public void RentCabinets(int M, int S, int[] spaces, int expected)
    {
        var actual = D075_RentCabinets.RentCabinets(M, S, spaces);
        Assert.Equal(expected, actual);
    }
}
