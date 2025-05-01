using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2943_MaximizeSquareHoleAreaTest
{
    [Theory]
    [InlineData("[2,3]", "[2]", 4)]
    [InlineData("[2]", "[2]", 4)]
    [InlineData("[2,3]", "[2,3,4]", 9)]
    [InlineData("[2,4]", "[2,4]", 4)]
    public void MaximizeSquareHoleArea(string A, string B, int expected)
    {
        var actual = _2943_MaximizeSquareHoleArea.MaximizeSquareHoleArea(A.ToArr(), B.ToArr());
        Assert.Equal(expected, actual);
    }
}
