# 最大子陣列問題（Maximum Subarray Problem）

## 一、問題定義
在一維數列中，**找出一段連續子陣列，其總和最大**。

**形式化描述：**  
給定整數陣列 `A[1...n]`，求一組索引 `(i, j)`，滿足 `1 ≤ i ≤ j ≤ n`，使得子陣列 `A[i] + A[i+1] + ... + A[j]` 的總和最大。

---

## 二、範例

對於陣列 `[-2, 1, -3, 4, -1, 2, 1, -5, 4]`  
最大子陣列為 `[4, -1, 2, 1]`，總和為 `6`。

---

## 三、性質與特例

1. **全為正數：** 最大子陣列為整個陣列。
2. **全為負數：** 最大子陣列為數值最大的單一元素（或空陣列，視定義而定）。
3. **可能有多組最大解：** 多段子陣列和可能一樣大。

---

## 四、解法比較

| Method                 | Time Complexity | Description                                      |
| ---------------------- | --------------- | ------------------------------------------------ |
| Brute Force            | O(n³)           | Triple loop to try all possible subarrays        |
| Prefix Sum + Brute     | O(n²)           | Uses prefix sum to reduce the cost of inner sums |
| Divide and Conquer     | O(n log n)      | Recursively splits array and combines border max |
| **Kadane's Algorithm** | **O(n)**        | Fastest and most practical linear-time solution  |

---

## 五、Kadane's 演算法

### 💡 核心概念
- 一次掃描陣列。
- `sub_sum`：當前以此位置結尾的最大子陣列和。
- `max_sub_sum`：目前為止掃描到的最大子陣列和。

### 📘 Python 範例程式碼
```python
def max_subarray(arr):
    max_sub_sum = float('-inf')  # 或 arr[0]，視是否允許空陣列
    sub_sum = 0
    for x in arr:
        sub_sum = max(x, sub_sum + x)
        max_sub_sum = max(max_sub_sum, sub_sum)
    return max_sub_sum
```
