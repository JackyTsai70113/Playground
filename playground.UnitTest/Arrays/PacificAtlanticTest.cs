using playground.Arrays;

namespace playground.UnitTest.Arrays;

public class PacificAtlanticTest
{
    [Theory]
    [InlineData("[[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]]", "[[0,4],[1,3],[1,4],[2,2],[3,0],[3,1],[4,0]]")]
    [InlineData("[[1]]", "[[0,0]]")]
    public void PacificAtlantic(string heights, string expected)
    {
        var actual = PacificAtlanticClass.PacificAtlantic(heights.To2dArr());


        Assert.Equal(expected.To2dArr(), actual);
    }
}
