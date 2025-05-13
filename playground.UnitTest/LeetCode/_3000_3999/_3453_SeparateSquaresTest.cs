using playground.LeetCode._3000_3999;

namespace playground.UnitTest.LeetCode._3000_3999;

public class _3453_SeparateSquaresTest
{
    [Theory]
    [InlineData("[[0,0,1],[2,2,1]]", 1.00000)]
    [InlineData("[[0,0,2],[1,1,1]]", 1.16667)]
    public void SeparateSquares(string squares, double expected)
    {
        var actual = _3453_SeparateSquares.SeparateSquares(squares.To2dArr());
        Assert.True(Math.Abs(actual - expected) < 0.00001);
    }
}
