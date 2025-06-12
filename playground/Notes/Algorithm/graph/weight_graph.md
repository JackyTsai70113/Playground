# 賦權圖 (Weighted Graph)

賦權圖是指每條邊都有一個權重的圖。在這種圖中，邊的權重通常用來表示兩個頂點之間的距離、時間或成本。賦權圖可以是有向圖或無向圖，並且在許多應用中，這些權重被用來求解最短路徑等問題。

## Dijkstra 算法

**Dijkstra 算法** 是一個用來求解賦權圖中從單一源點到所有其他頂點最短路徑的算法。它適用於邊的權重為非負數的圖。

### 主要步驟：
1. 初始化源點的距離為 0，其他頂點的距離為無窮大。
2. 訪問所有未處理的頂點，對每個頂點，更新其相鄰頂點的距離。
3. 選擇當前距離最小的未處理頂點，重複這一過程，直到所有頂點的最短距離確定。

### 應用場景：
- 最短路徑問題，例如網絡路由、交通規劃等。

### C# 範本：
```csharp
public class Dijkstra
{
    public static Dictionary<int, int> DijkstraAlgorithm(List<(int node, int dist)>[] graph, int start)
    {
        var distances = new Dictionary<int, int>();
        var priorityQueue = new PriorityQueue<int, int>();

        // 初始化每個頂點的距離為無窮大
        for (int i = 0; i < graph.Length; i++)
        {
            distances[i] = int.MaxValue;
        }

        // 設定起始點的距離為 0
        distances[start] = 0;
        priorityQueue.Enqueue(start, 0);

        while (priorityQueue.Count > 0)
        {
            int currentNode = priorityQueue.Dequeue();
            int currentDistance = distances[currentNode];

            // 遍歷當前頂點的所有鄰居
            foreach (var neighbor in graph[currentNode])
            {
                int neighborNode = neighbor.node;
                int weight = neighbor.dist;

                // 計算從起點到鄰居的距離
                int newDist = currentDistance + weight;
                if (newDist < distances[neighborNode])
                {
                    distances[neighborNode] = newDist;
                    priorityQueue.Enqueue(neighborNode, newDist);
                }
            }
        }

        return distances;
    }
}
```
## Floyd-Warshall 算法

**Floyd-Warshall 算法** 是一個用來求解賦權圖中所有頂點對間最短路徑的動態規劃算法。它可以處理正數或負數權重的邊，但不能有負環。

### 負環的定義：
**負環** 是指在圖中存在一個回路，其中所有邊的總權重為負數。這樣的回路會使得最短路徑無窮小，因此無法計算出正確的最短路徑。

### 主要步驟：
1. 初始化距離矩陣，設置每對頂點間的初始距離（如果存在邊，設為邊的權重，否則設為無窮大）。
2. 通過動態規劃，逐步更新每對頂點的最短距離。對於每一對頂點 $(i, j)$，嘗試通過中介頂點 $k$ 更新最短路徑，即：  
   \[
   dist[i][j] = \min(dist[i][j], dist[i][k] + dist[k][j])
   \]
3. 最終得到每一對頂點之間的最短距離。

### 應用場景：
- 所有頂點對間的最短路徑問題，適用於密集圖，且可以處理負邊權重。

### C# 範本：
```csharp
public class FloydWarshall
{
    public static void FloydWarshallAlgorithm(int[,] graph)
    {
        int vertices = graph.GetLength(0);

        // 使用動態規劃更新最短路徑
        for (int k = 0; k < vertices; k++)
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    if (graph[i, k] != int.MaxValue && graph[k, j] != int.MaxValue && graph[i, j] > graph[i, k] + graph[k, j])
                    {
                        graph[i, j] = graph[i, k] + graph[k, j];
                    }
                }
            }
        }
    }
}
```
## 比較 Dijkstra 算法 和 Floyd-Warshall 算法

### Dijkstra 算法
- **應用範圍**：適用於單源最短路徑問題，且權重必須是非負的。
- **時間複雜度**：時間複雜度為 $O((V + E) \log V)$，其中 $V$ 是頂點數，$E$ 是邊數。
- **空間複雜度**： $O(V + E)$。

### Floyd-Warshall 算法
- **應用範圍**：適用於所有頂點對間的最短路徑問題，支持負邊權重但不支持負環。
- **時間複雜度**：時間複雜度為 $O(V^3)$，其中 $V$ 是頂點數。
- **空間複雜度**： $O(V^2)$，需要一個 $V \times V$ 的矩陣來存儲最短距離。

## 結論
- **Dijkstra 算法**: 稀疏圖用。更適合解決單源最短路徑問題，特別是當圖較為稀疏時。
- **Floyd-Warshall 算法**: 密集圖用。則適用於解決所有頂點對之間的最短路徑問題，尤其是當圖較為密集，且可能包含負邊權重時。
