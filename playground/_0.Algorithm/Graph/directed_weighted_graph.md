# directed weighted graph(有向賦權圖)

## Construct

```csharp
private static Dictionary<int, List<(int n, int w)>> Construct(int[][] edges)
{
    var g = new Dictionary<int, List<(int n, int w)>>();
    foreach (var e in edges)
    {
        if (!g.ContainsKey(e[0])) g[e[0]] = new();
        g[e[0]].Add((e[1], e[2]));
    }
    return g;
}
```
