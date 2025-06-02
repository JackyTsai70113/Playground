using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1039_MinScoreTriangulationTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 6)]
    [InlineData(new int[] { 3, 7, 4, 5 }, 144)]
    [InlineData(new int[] { 1, 3, 1, 4, 1, 5 }, 13)]
    public void MinScoreTriangulation(int[] A, int expected)
    {
        int actual;
        actual = _1039_MinScoreTriangulation.MinScoreTriangulation_BU(A);
        Assert.Equal(expected, actual);
        actual = _1039_MinScoreTriangulation.MinScoreTriangulation_TD(A);
        Assert.Equal(expected, actual);
    }
}
