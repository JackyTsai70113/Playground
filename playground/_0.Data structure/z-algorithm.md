# Z algorithm (Linear time pattern searching Algorithm)

此演算法能夠以線性時間複雜度搜尋特定 pattern 存在 text 中的狀況。

## Z Array

z 的元素(z[i])為 str[i] 和 str[0..n-1] 相同的最長的子字串長度。

```text
Example:

Index      0   1   2   3   4   5   6   7   8   9  10  11 
Text       a   a   b   c   a   a   b   x   a   a   a   z
z[]        X   1   0   0   3   1   0   0   2   2   1   0

Index      0   1   2   3   4   5
str        a   a   a   a   a   a
z[]        6   5   4   3   2   1

Index      0   1   2   3   4   5   6
str        a   a   b   a   a   c   d
z[]        7   1   0   2   1   0   0 

Index      0   1   2   3   4   5   6   7
str        a   b   a   b   a   b   a   b
z[]        x   0   6   0   4   0   2   0
```

```csharp
// Fills Z array for given string str[]
// z函數
// https://www.youtube.com/watch?v=2EqYY0c--QI
// https://personal.utdallas.edu/~besp/demo/John2010/z-algorithm.htm
private static int[] GetZArr(string str)
{
    int n = str.Length;
    int left = 0, right = 0; // l, r 定義了 z-box(已匹配prefix的滑動窗口)
    var z = new int[n];
    for (int i = 1; i < n; i++)
    {
        if (i <= right) // i 在 z-box 裡
            z[i] = Math.Min(z[i - left], right - i + 1); // z函數核心思想
        while (i + z[i] < n && str[z[i]] == str[i + z[i]])
        {
            (left, right) = (i, i + z[i]);
            z[i]++;
        }
    }
    return z;
}
```