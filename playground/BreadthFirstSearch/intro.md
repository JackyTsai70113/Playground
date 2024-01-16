# BFS

- template

```csharp
/**
 * Return the length of the shortest path between root and target node.
 */
int BFS(Node root, Node target) {
    if(root.val == target.val)
        return 0;
    Queue<Node> q = new();
    HashSet<Node> seen = new();
    int step = 0;
    q.Enqueue(root);
    seen.Add(root);
    while (q.Count > 0)
    {
        for(int i = q.Count; i > 0; --i)
        {
            var u = q.Dequeue();
            if(v.val == target.val)
                return step;
            foreach(var v in graph[u]) {
                if (!seen.Contains(v)) {
                    q.Enqueue(v);
                    seen.Add(v);
                }  
            }
        }
        step++;
    }
    return -1;
}
```
