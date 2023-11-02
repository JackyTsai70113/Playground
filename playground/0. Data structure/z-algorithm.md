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
private static void getZarr(string str,
                            int[] Z)
{
 
    int n = str.Length;
 
    // [L,R] make a window which 
    // matches with prefix of s 
    int L = 0, R = 0;
 
    for (int i = 1; i < n; ++i)
    {
 
        // if i>R nothing matches so we will 
        // calculate. Z[i] using naive way. 
        if (i > R)
        {
            L = R = i;
 
            // R-L = 0 in starting, so it will start 
            // checking from 0'th index. For example, 
            // for "ababab" and i = 1, the value of R 
            // remains 0 and Z[i] becomes 0. For string 
            // "aaaaaa" and i = 1, Z[i] and R become 5 
            while (R < n && str[R - L] == str[R])
            {
                R++;
            }
 
            Z[i] = R - L;
            R--;
 
        }
        else
        {
 
            // k = i-L so k corresponds to number 
            // which matches in [L,R] interval. 
            int k = i - L;
 
            // if Z[k] is less than remaining interval 
            // then Z[i] will be equal to Z[k]. 
            // For example, str = "ababab", i = 3, 
            // R = 5 and L = 2 
            if (Z[k] < R - i + 1)
            {
                Z[i] = Z[k];
            }
 
            // For example str = "aaaaaa" and 
            // i = 2, R is 5, L is 0 
            else
            {
 
 
                // else start from R and 
                // check manually 
                L = i;
                while (R < n && str[R - L] == str[R])
                {
                    R++;
                }
 
                Z[i] = R - L;
                R--;
            }
        }
    }
}

```
