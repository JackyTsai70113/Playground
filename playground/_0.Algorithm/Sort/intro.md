# Sort

## CPP 的 sort

```CPP
// 起終點的型態是 T1
template<class T1>
void sort(T1 first, T1 last);

// 起終點的型態是 T1, 函式指標的型態為 T2
template<class T1, class T2>
void sort(T1 first, T1 last, T2 pointer)
```

### 內觀排序 introsort

- STL 中的排序法是混合排序法 hybrid sorting algorithm
- 原則上使用快速排序法 Quick sort,
- 同時監控遞迴的深度, 當太深時就採用 Heap sort,
- 若長度降到一定長度以下, 則採用 Insert sort

| Sort      | Best Case | Average Case | Worst Case |
| --------- | --------- | ------------ | ---------- |
| Insertion | O(n)      | O(n^2)       | O(n^2)     |
| Shell     | O(n)      | O(n^1.25)    | O(n^2)     |
| Selection | O(n^2)    | O(n^2)       | O(n^2)     |
| Bubble    | O(n^2)    | O(n^2)       | O(n^2)     |
| Shaker    | O(n)      | O(n^2)       | O(n^2)     |
| Quick     | O(nlogn)  | O(nlogn)     | O(n^2)     |
| Heap      | O(nlogn)  | O(nlogn)     | O(nlogn)   |
| Merge     | O(nlogn)  | O(nlogn)     | O(nlogn)   |

- C++ 內觀排序法
  - 原則上採取 Quick sort
  - 監控遞迴的深度，太深(>log(n))時，改採 Heap sort
  - 長度下降到一定程度(20筆)，採用Insertion sort
