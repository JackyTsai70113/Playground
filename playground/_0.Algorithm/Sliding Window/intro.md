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
    int max = 0;
    for (int l = 0, r = 0; r < nums.Length; r++)
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
    int min = int.MaxValue;
    for (int l = 0, r = 0; r < nums.Length; r++)
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

1. At Most to Equal

    ```csharp
    public static int NeedEqual(int[] nums, int k)
    {
        return AtMost(nums, k) - AtMost(nums, k - 1);
    }

    private static int AtMost(int[] nums, int k)
    {
        bool Valid()
        {
            return false;
        }
        int res = 0;
        for (int l = 0, r = 0; r < nums.Length; r++)
        {
            // update state by A[r]
            while (l <= r && !Valid())
            {
                // update state by A[l]
                l++;
            }
            res += r - l + 1;
        }
        return res;
    }
    ```

- ref: <https://liuzhenglaichn.gitbook.io/algorithm/array/sliding-window>
