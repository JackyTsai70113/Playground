namespace playground;

public class MaximumElementAfterDecrementingAndRearranging_1846
{
    public static int MaximumElementAfterDecrementingAndRearranging(int[] arr) {
        Array.Sort(arr);
        var res = 0;
        foreach(var num in arr)
            res = Math.Min(res + 1, num);
        return res;
    }
}
