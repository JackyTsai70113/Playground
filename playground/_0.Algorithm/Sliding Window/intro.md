# Sliding Window

- 可以透過兩個 pointer 和 一個 hashmap 來尋找在限制底下的 substring

## template

### Maximum Window

1. Find Maximum Window

    ```csharp
    bool Valid()
    {
        return false;
    }
    int l = 0, max = 0;
    for (int r = 0; r < n; r++)
    {
        // update state by A[r]
        while (l <= r && !Valid())
        {
            // update state by A[l]
            l++;
        }
        if (Valid())
            max = Math.Max(max, r - l + 1);
    }
    return max;
    ```

1. Find Minimum Window

    ```csharp
    bool Valid()
    {
        return false;
    }
    int l = 0, min = int.MaxValue;
    for (int r = 0; r < n; r++)
    {
        // update state by A[r]
        while (l <= r && Valid())
        {
            min = Math.Min(min, r - l + 1);
            // update state by A[l]
            l++;
        }
    }
    return min == int.MaxValue ? 0 : min;
    ```

- ref: <https://liuzhenglaichn.gitbook.io/algorithm/array/sliding-window>
