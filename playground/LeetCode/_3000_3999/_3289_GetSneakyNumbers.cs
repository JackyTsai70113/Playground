namespace playground;

public class _3289_GetSneakyNumbers
{
    public static int[] GetSneakyNumbers(int[] nums)
    {
        var res = new List<int>();
        var set = new HashSet<int>();
        foreach (var num in nums)
        {
            if (!set.Add(num))
                res.Add(num);
        }
        return res.ToArray();
    }
}
