using System.Text.Json;

namespace playground.UnitTest;

public class GraphTest2642
{
    [Theory]
    [InlineData(new string[] { "Graph", "shortestPath", "shortestPath", "addEdge", "shortestPath" }, new string[] { "[4,[[0,2,5],[0,1,2],[1,2,1],[3,0,3]]]", "[3,2]", "[0,3]", "[[1,3,4]]", "[0,3]" }, "[null,6,-1,null,6]")]
    [InlineData(new string[] { "Graph", "shortestPath" }, new string[] { "[4,[[0,2,5],[3,1,2]]]", "[0,3]" }, "[null,-1]")]
    public void Graph(string[] functions, string[] valStr, string expectedStr)
    {
        var expected = expectedStr.ToArr<int?>();
        var ctorObjects = valStr[0].ToArr<object>();
        int n = int.Parse(JsonSerializer.Serialize(ctorObjects[0]));
        var edges = JsonSerializer.Serialize(ctorObjects[1]).To2dArr();
        var graph = new Graph2642(n, edges);
        for (int i = 1; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "addEdge":
                    var addedEdges = valStr[i].To2dArr();
                    graph.AddEdge(addedEdges[0]);
                    break;
                case "shortestPath":
                    var nodes = valStr[i].ToArr();
                    var actual = graph.ShortestPath(nodes[0], nodes[1]);
                    Assert.Equal(expected[i].Value, actual);
                    break;
                default:
                    break;
            }
        }
    }
}
