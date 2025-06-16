using System.Collections.Generic;
using playground.Helpers.Graph;
using Xunit;

namespace playground.UnitTest.Helpers.Graph;

public class UndirectedGraphCCFinderTest
{
    [Fact]
    public void FindConnectedComponents_BFS_SimpleGraph()
    {
        // Arrange
        int n = 5;
        int[][] edges = new int[][]
        {
            new int[] { 0, 1 },
            new int[] { 1, 2 },
            new int[] { 3, 4 }
        };

        // Act
        var finder = new UndirectedGraphCCFinder(n, edges);
        var result = finder.FindConnectedComponents_BFS();

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Contains(result, cc => new HashSet<int>(cc).SetEquals(new[] { 0, 1, 2 }));
        Assert.Contains(result, cc => new HashSet<int>(cc).SetEquals(new[] { 3, 4 }));
    }

    [Fact]
    public void FindConnectedComponents_DFS_SimpleGraph()
    {
        // Arrange
        int n = 5;
        int[][] edges = new int[][]
        {
            new int[] { 0, 1 },
            new int[] { 1, 2 },
            new int[] { 3, 4 }
        };

        // Act
        var finder = new UndirectedGraphCCFinder(n, edges);
        var result = finder.FindConnectedComponents_DFS();

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Contains(result, cc => new HashSet<int>(cc).SetEquals(new[] { 0, 1, 2 }));
        Assert.Contains(result, cc => new HashSet<int>(cc).SetEquals(new[] { 3, 4 }));
    }

    [Fact]
    public void FindConnectedComponents_BFS_AllDisconnected()
    {
        // Arrange
        int n = 3;
        int[][] edges = Array.Empty<int[]>();

        // Act
        var finder = new UndirectedGraphCCFinder(n, edges);
        var result = finder.FindConnectedComponents_BFS();

        // Assert
        Assert.Equal(3, result.Count);
        foreach (var cc in result)
            Assert.Single(cc);
    }

    [Fact]
    public void FindConnectedComponents_DFS_AllDisconnected()
    {
        // Arrange
        int n = 3;
        int[][] edges = Array.Empty<int[]>();

        // Act
        var finder = new UndirectedGraphCCFinder(n, edges);
        var result = finder.FindConnectedComponents_DFS();

        // Assert
        Assert.Equal(3, result.Count);
        foreach (var cc in result)
            Assert.Single(cc);
    }
}