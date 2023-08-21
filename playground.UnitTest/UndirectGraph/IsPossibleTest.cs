using playground.UndirectedGraph;

namespace playground.UnitTest.UndirectGraph;

public class IsPossibleTest
{
    [Theory]
    [InlineData(5, "[[1,2],[2,3],[3,4],[4,2],[1,4],[2,5]]", true)]
    [InlineData(4, "[[1,2],[3,4]]", true)]
    [InlineData(4, "[[1,2],[1,3],[1,4]]", false)]
    [InlineData(2, "[[1,2]]", false)]
    [InlineData(4, "[[1,2],[2,3],[3,4],[1,4]]", true)]
    [InlineData(6, "[[1,6],[1,3],[1,4],[4,5],[5,2]]", true)]
    [InlineData(6, "[[1,2],[1,6],[1,4],[4,5],[5,3]]", true)]
    [InlineData(6, "[[1,2],[1,3],[1,4],[4,5],[5,6]]", true)]
    public void IsPossible(int n, string edges, bool expected)
    {
        List<IList<int>> newEdges = new();
        foreach (var e in edges.To2dArr())
            newEdges.Add(e);
        var actual = IsPossibleClass.IsPossible(n, newEdges);
        Assert.Equal(expected, actual);
    }
}
