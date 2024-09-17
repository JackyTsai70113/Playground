namespace playground;

public class GetSneakyNumbers3289
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
