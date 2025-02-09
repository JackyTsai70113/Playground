using playground._2600_2699;

namespace playground.UnitTest._2600_2699;

public class _2658_FindMaxFishTest
{
    [Theory]
    [InlineData("[[0,2,1,0],[4,0,0,3],[1,0,0,4],[0,3,2,0]]", 7)]
    [InlineData("[[1,0,0,0],[0,0,0,0],[0,0,0,0],[0,0,0,1]]", 1)]
    public void MinimumCost(string A, int expected)
    {
        var actual = _2658_FindMaxFish.FindMaxFish(A.To2dArr());
        Assert.Equal(expected, actual);
    }
}
