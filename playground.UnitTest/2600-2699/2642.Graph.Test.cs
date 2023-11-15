using System.Text.Json;

namespace playground;

public class GraphTest
{
    [Theory]
    [InlineData(new string[] { "Graph", "shortestPath", "shortestPath", "addEdge", "shortestPath" }, new string[] { "[4,[[0,2,5],[0,1,2],[1,2,1],[3,0,3]]]", "[3,2]", "[0,3]", "[[1,3,4]]", "[0,3]" }, "[null,6,-1,null,6]")]
    public void Graph(string[] functions, string[] valStr, string expectedStr)
    {
        var expected = expectedStr.ToArr<int?>();
        Graph_2642 graph = new();
        for (int i = 0; i < functions.Length; ++i)
        {
            switch (functions[i])
            {
                case "Graph":
                    var ctorObjects = valStr[i].ToArr<object>();
                    int n = int.Parse(JsonSerializer.Serialize(ctorObjects[0]));
                    var ctorEdges = JsonSerializer.Serialize(ctorObjects[1]).To2dArr();
                    graph = new Graph_2642(n, ctorEdges);
                    break;
                case "addEdge":
                    var addedEdges = valStr[i].To2dArr();
                    graph.AddEdge(addedEdges[0]);
                    break;
                case "shortestPath":
                    var nodes = valStr[i].ToArr();
                    int cost = graph.ShortestPath(nodes[0], nodes[1]);
                    Assert.Equal(expected[i].Value, cost);
                    break;
                default:
                    break;
            }
        }
    }
}
