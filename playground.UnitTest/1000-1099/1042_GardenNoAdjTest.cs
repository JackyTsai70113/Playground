using playground._1000_1099;

namespace playground.UnitTest._1000_1099;

public class _1042_GardenNoAdjTest
{
    [Theory]
    [InlineData(3, "[[1,2],[2,3],[3,1]]", new int[] { 1, 2, 3 })]
    [InlineData(4, "[[1,2],[3,4]]", new int[] { 1, 2, 1, 2 })]
    [InlineData(4, "[[1,2],[2,3],[3,4],[4,1],[1,3],[2,4]]", new int[] { 1, 2, 3, 4 })]
    public void GardenNoAdj(int n, string path, int[] expected)
    {
        var actual = _1042_GardenNoAdj.GardenNoAdj(n, path.To2dArr());
        Assert.Equal(expected, actual);
    }
}
