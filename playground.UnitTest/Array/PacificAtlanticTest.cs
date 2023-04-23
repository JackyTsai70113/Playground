using NuGet.Frameworks;
using playground.Array;
using playground.UnitTest.Utils;

namespace playground.UnitTest.Array;

public class PacificAtlanticTest
{
    [Theory]
    [InlineData("[[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]]", "[[0,4],[1,3],[1,4],[2,2],[3,0],[3,1],[4,0]]")]
    [InlineData("[[1]]", "[[0,0]]")]
    public void PacificAtlantic(string arr, string arr2)
    {
        var heights = arr.To2dArr<int>();

        var actual = PacificAtlanticClass.PacificAtlantic(heights);

        var expected = arr2.To2dArr<int>();

        Assert.Equal(expected, actual);
    }
}
