using playground._1000_1099;

namespace playground.UnitTest._1000_1099;

public class _1040_NumMovesStonesIITest
{
    [Theory]
    [InlineData(new int[] { 7, 4, 9 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 6, 5, 4, 3, 10 }, new int[] { 2, 3 })]
    [InlineData(new int[] { 3, 4, 5, 7, 8 }, new int[] { 1, 1 })]
    [InlineData(new int[] { 1, 3, 5 }, new int[] { 1, 1 })]
    [InlineData(new int[] { 1, 3, 4 }, new int[] { 1, 1 })]
    [InlineData(new int[] { 1, 5, 10 }, new int[] { 2, 4 })]
    [InlineData(new int[] { 2, 3, 7 }, new int[] { 2, 3 })]
    [InlineData(new int[] { 3, 4, 5, 6, 200 }, new int[] { 2, 193 })]
    [InlineData(new int[] { 3, 4, 5, 6, 7 }, new int[] { 0, 0 })]
    public void NumMovesStonesII_Test(int[] A, int[] expected)
    {
        var solution = new _1040_NumMovesStonesII();
        var actual = solution.NumMovesStonesII(A);
        Assert.Equal(expected, actual);
    }
}
