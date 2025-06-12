# Kahn's Algorithm 完整筆記

## 什麼是 Kahn's Algorithm？
Kahn's Algorithm 是用於解決 **拓撲排序** 問題的經典演算法，適用於有向無環圖（DAG, Directed Acyclic Graph）。拓撲排序是將圖中的所有頂點線性排列，這樣對於每一條有向邊 $(u, v)$，頂點 $u$ 都會出現在頂點 $v$ 之前。

## 主要用途：
1. **拓撲排序（Topological Sorting）**：將有向無環圖的所有節點排列為一個線性順序，使得每條邊的起點都排在終點之前。
2. **判斷是否有環（Cycle Detection）**：在拓撲排序過程中，若圖中存在環，則無法進行完整的排序，因此可以用來檢測圖中是否有環。

## Kahn's Algorithm 步驟：

1. **計算每個節點的入度**：
   - 計算圖中每個節點的入度，即有多少條邊指向該節點。

2. **初始化佇列**：
   - 將所有入度為零的節點（即沒有依賴的節點）加入佇列中。這些節點可以放置在拓撲排序的最前端。

3. **處理佇列中的節點**：
   - 當佇列中有節點時，取出一個節點並將其加入拓撲排序結果中。
   - 遍歷與該節點相連的邊，將相鄰節點的入度減少 1。
   - 如果某個相鄰節點的入度變為零，則將其加入佇列中。

4. **檢查是否所有節點都處理完畢**：
   - 如果所有節點都被處理且排序結果包含所有節點，則該排序是有效的拓撲排序。
   - 如果佇列處理完畢後還有節點未處理，則圖中存在環，無法進行拓撲排序。

## Kahn's Algorithm 代碼範例（Python）：

```python
from collections import deque, defaultdict

def kahn_algorithm(graph):
    # 計算入度
    in_degree = defaultdict(int)
    for node in graph:
        for neighbor in graph[node]:
            in_degree[neighbor] += 1

    # 初始化佇列，加入入度為 0 的節點
    queue = deque([node for node in graph if in_degree[node] == 0])
    result = []

    while queue:
        node = queue.popleft()
        result.append(node)

        for neighbor in graph[node]:
            in_degree[neighbor] -= 1
            if in_degree[neighbor] == 0:
                queue.append(neighbor)

    # 檢查是否所有節點都被處理
    if len(result) == len(graph):
        return result  # 成功的拓撲排序
    else:
        return "Graph has a cycle!"  # 如果圖中有環
