namespace playground._0600_0699;

public class _0632_SmallestRange
{
    public static int[] SmallestRange(IList<IList<int>> nums)
    {
        (int x, int i)[] arr = new (int, int)[nums.Select(x => x.Count).Sum()];
        for (int i = 0, j = 0; i < nums.Count; i++)
        {
            foreach (var num in nums[i])
            {
                arr[j++] = (num, i);
            }
        }
        Array.Sort(arr, (x, y) => x.x - y.x);
        var cnts = new int[nums.Count];
        int count = 0;
        var res = new int[] { -1, -1 };
        for (int l = 0, r = 0; r < arr.Length; r++)
        {
            var (rightElement, i) = arr[r];
            if (cnts[i]++ == 0)
                count++;
            while (count == nums.Count)
            {
                var (leftElement, j) = arr[l];
                if (res[0] == -1 || res[1] - res[0] > rightElement - leftElement)
                {
                    res[0] = leftElement;
                    res[1] = rightElement;
                }
                if (--cnts[j] == 0)
                {
                    count--;
                }
                l++;
            }
        }
        return res;
    }
}