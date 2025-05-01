using playground.LeetCode._2000_2999;

namespace playground.UnitTest.LeetCode._2000_2999;

public class _2251_FullBloomFlowersTest
{
    [Theory]
    [InlineData("[[1,6],[3,7],[9,12],[4,13]]", new int[] { 2, 3, 7, 11 }, new int[] { 1, 2, 2, 2 })]
    [InlineData("[[1,10],[3,3]]", new int[] { 3, 3, 2 }, new int[] { 2, 2, 1 })]
    [InlineData("[[36,39],[29,49],[32,35],[14,43],[42,49],[48,48],[32,46],[6,41],[14,19]]", new int[] { 14, 4 }, new int[] { 3, 0 })]
    [InlineData("[[43,50],[31,39],[37,42],[38,47],[22,25],[31,42],[29,43],[15,30],[37,42]]", new int[] { 47, 4, 12, 12, 30, 18, 17 }, new int[] { 2, 0, 0, 0, 2, 1, 1 })]
    public void FullBloomFlowers(string flowers, int[] people, int[] expected)
    {
        var actual = _2251_FullBloomFlowers.FullBloomFlowers(flowers.To2dArr(), people);
        Assert.Equal(expected, expected);
    }
}
