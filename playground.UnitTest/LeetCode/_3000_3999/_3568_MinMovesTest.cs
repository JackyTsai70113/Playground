using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3568_MinMovesTest
{
    [Theory]
    [InlineData(new string[] { "S.", "XL" }, 2, 2)]
    [InlineData(new string[] { "LS", "RL" }, 4, 3)]
    [InlineData(new string[] { "L.S", "RXL" }, 3, -1)]
    public void MinAbsDiff(string[] A, int energy, int expected)
    {
        var actual = _3568_MinMoves.MinMoves(A, energy);
        Assert.Equal(expected, actual);
    }
}