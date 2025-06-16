using System.Text.Json;
using playground.Helpers.Graph;

namespace playground.UnitTest.Helpers.Graph;

public class DirectedGraphSCCFinderTest
{
    [Theory]
    [InlineData(5, "[[0,1],[1,2],[2,0],[3,4],[4,3]]", "[[0,1,2],[3,4]]")]
    [InlineData(7, "[[0,1],[0,2],[1,0],[2,1],[2,3],[2,4],[3,4],[4,5],[5,4],[5,6],[6,4]]", "[[0,1,2],[3],[4,5,6]]")]
    public void FindConnectedComponents_DFS_SimpleGraph(int n, string edgesStr, string expectedStr)
    {
        // Arrange

        // Act
        var finder = new DirectedGraphSCCFinder(n, edgesStr.To2dArr());
        var result = finder.FindStronglyConnectedComponents();

        // Assert
        var expected = expectedStr.To2dArr();
        Assert.True(expected.Length == result.Count &&
            Enumerable.SequenceEqual(expected.SelectMany(x => x).OrderBy(x => x),
                                    result.SelectMany(x => x).OrderBy(x => x)),
                JsonSerializer.Serialize(result) + " " + JsonSerializer.Serialize(expected));
    }
}