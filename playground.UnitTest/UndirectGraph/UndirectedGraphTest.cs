using playground.UndirectedGraph;
using playground.UnitTest.Utils;

namespace playground.UnitTest.UndirectedGraph;

public partial class UndirectedGraphTest
{
    [Theory]
    [InlineData(4, 0, new int[] { 1, 2 }, 4, new int[] { 0, -1, -1, 1 })]
    [InlineData(5, 0, new int[] { 2, 4 }, 3, new int[] { 0, -1, -1, -1, -1 })]
    [InlineData(4, 2, new int[] { 0, 1, 3 }, 1, new int[] { -1, -1, 0, -1 })]
    [InlineData(5, 0, new int[] { }, 2, new int[] { 0, 1, 2, 3, 4 })]
    [InlineData(6, 0, new int[] { }, 4, new int[] { 0, 3, 2, 1, 2, 3 })]
    [InlineData(8, 6, new int[] { 0 }, 5, new int[] { -1, -1, 1, -1, 1, -1, 0, -1 })]
    public void MinReverseOperationsTest(int n, int p, int[] banned, int k, int[] expect)
    {
        int[] result = MinReverseOperationsClass.MinReverseOperations(n, p, banned, k);
        Assert.Equal(expect, result);
    }

    [Theory]
    [MemberData(nameof(Data), 0)]
    [InlineData(1, new int[] { }, new int[] { 0 })]
    [InlineData(2, new int[] { 0, 1 }, new int[] { 0, 1 })]
    [InlineData(4, new int[] { 1, 0, 1, 2, 1, 3 }, new int[] { 1 })]
    [InlineData(6, new int[] { 3, 0, 3, 1, 3, 2, 3, 4, 5, 4 }, new int[] { 3, 4 })]
    [InlineData(4, new int[] { 0, 1, 1, 2, 2, 3 }, new int[] { 1, 2 })]
    public void FindMinHeightTrees(int n, int[] array, int[] expect)
    {
        int[][] edges = array.To2dArray(2);
        IList<int> result = FindMinHeightTreesClass.FindMinHeightTrees(n, edges);
        Assert.Equal(expect, result.ToArray());
    }
}