namespace playground;

public class _3229_MinimumOperations
{
    public long MinimumOperations(int[] nums, int[] target)
    {
        int n = nums.Length;
        var arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = target[i] - nums[i];
        }
        return Dfs(arr, 0, arr.Length - 1, 0);
    }

    long Dfs(int[] arr, int start, int end, long pre)
    {
        if (start > end)
            return 0;
        if (arr[start] == pre)
            return Dfs(arr, start + 1, end, pre);
        if (arr[end] == pre)
            return Dfs(arr, start, end - 1, pre);
        if (arr[start] > pre && arr[end] > pre)
        {
            int min = Math.Min(arr[start], arr[end]);
            return min - pre + Dfs(arr, start, end, min);
        }
        else if (arr[start] < pre && arr[end] < pre)
        {
            int max = Math.Max(arr[start], arr[end]);
            return pre - max + Dfs(arr, start, end, max);
        }
        else
        {
            int firstDiff = start;
            while ((pre - arr[firstDiff]) * (pre - arr[end]) < 0)
            {
                firstDiff++;
            }
            return Dfs(arr, start, firstDiff - 1, pre) + Dfs(arr, firstDiff, end, pre);
        }
    }
}
