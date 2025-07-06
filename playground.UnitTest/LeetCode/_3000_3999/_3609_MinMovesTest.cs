using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3609_MinMovesTest
{
    [Theory]
    [InlineData(1, 2, 5, 4, 2)]
    [InlineData(0, 0, 9, 6, -1)]
    [InlineData(0, 1, 2, 3, 3)]
    [InlineData(1, 1, 2, 2, -1)]
    [InlineData(1, 1, 1, 1, 0)]
    [InlineData(2, 3, 6, 7, -1)]
    [InlineData(2, 3, 5, 4, -1)]
    [InlineData(2, 3, 7, 8, -1)]
    [InlineData(2, 3, 8, 9, -1)]
    [InlineData(2, 3, 10, 11, -1)]
    [InlineData(1, 0, 4480, 36448, 19)]
    public void MinMoves(int sx, int sy, int tx, int ty, int expected)
    {
        var actual = _3609_MinMoves.MinMoves(sx, sy, tx, ty);
        Assert.Equal(expected, actual);
    }
}
