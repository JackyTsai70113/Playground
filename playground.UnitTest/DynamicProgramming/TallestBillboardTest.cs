using playground.DynamicProgramming;

namespace playground.UnitTest.DynamicProgramming;

public class TallestBillboardTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 6 }, 6)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 10)]
    [InlineData(new int[] { 1, 2 }, 0)]
    [InlineData(new int[] { 61, 45, 43, 54, 40, 53, 55, 47, 51, 59, 42 }, 275)]
    public void TallestBillboard(int[] rods, int expected)
    {
        var actual = TallestBillboardClass.TallestBillboard(rods);
        Assert.Equal(expected, actual);
    }
}
