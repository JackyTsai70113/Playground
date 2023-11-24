namespace playground;

public class CheckArithmeticSubarrays_1630
{
    public static IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        var starts = Enumerable
            .Range(0, l.Length)
            .Select(i => new int[] { i, l[i], r[i] })
            .OrderBy(x => x[1])
            .ThenBy(x => x[2])
            .ToList();
        List<int> arr = new();
        var res = new bool[l.Length];
        for (int i = 0; i < l.Length; ++i)
        {
            if (i == 0 || starts[i - 1][1] != starts[i][1])
            {
                arr = new();
                for (int j = starts[i][1]; j <= starts[i][2]; j++)
                    arr.Add(nums[j]);
            }
            else
            {
                for (int j = starts[i - 1][2] + 1; j <= starts[i][2]; j++)
                    arr.Add(nums[j]);
            }
            arr.Sort();
            res[starts[i][0]] = true;
            for (int j = 2; j < arr.Count; j++)
            {
                if (arr[j - 2] - arr[j - 1] != arr[j - 1] - arr[j])
                {
                    res[starts[i][0]] = false;
                    break;
                }
            }
        }
        return res.ToList();
    }
}
