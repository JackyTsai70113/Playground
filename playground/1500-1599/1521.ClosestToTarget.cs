namespace playground;

public class ClosestToTarget_1521
{
    /// <summary>
    /// https://leetcode.com/problems/find-a-value-of-a-mysterious-function-closest-to-target
    /// </summary>
    public static int ClosestToTarget(int[] arr, int target)
    {
        int n = arr.Length, res = int.MaxValue;
        var sets = new HashSet<int>[n];
        for (int i = 0; i < n; i++)
            sets[i] = new();
        sets[^1].Add(arr[^1]);
        for (int i = n - 2; i >= 0; --i)
        {
            sets[i].Add(arr[i]);
            foreach(var num in sets[i+1]){
                sets[i].Add(arr[i] & num);
            }
        }
        foreach(var set in sets){
            foreach(var num in set){
                res = Math.Min(res, Math.Abs(num - target));
            }
        }
        return res;
    }
}
