using playground.LeetCode._1000_1999;

namespace playground.UnitTest.LeetCode._1000_1999;

public class _1007_MinDominoRotationsTest
{
    [Theory]
    [InlineData(new int[] { 2, 1, 2, 4, 2, 2 }, new int[] { 5, 2, 6, 2, 3, 2 }, 2)]
    [InlineData(new int[] { 3, 5, 1, 2, 3 }, new int[] { 3, 6, 3, 3, 4 }, -1)]
    [InlineData(new int[] { 2, 1, 2, 2, 2, 2 }, new int[] { 5, 2, 6, 2, 3, 2 }, 1)]
    [InlineData(new int[] { 1, 1, 1, 2, 1, 1, 1, 2, 1, 1, 2, 1, 1, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 2 },
                new int[] { 2, 2, 1, 1, 1, 1, 2, 1, 2, 2, 1, 2, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1 }, 6)]
    [InlineData(new int[] { 1, 1, 2, 1 }, new int[] { 2, 1, 1, 2 }, 1)]
    public void Test(int[] tops, int[] bottoms, int expected)
    {
        var result = _1007_MinDominoRotations.MinDominoRotations(tops, bottoms);
        Assert.Equal(expected, result);
    }
}
