namespace playground;

public class _3005_MaxFrequencyElements
{
    /// <summary>
    /// https://leetcode.com/problems/count-elements-with-maximum-frequency
    /// </summary>
    public static int MaxFrequencyElements(int[] nums) {
        var d = new Dictionary<int, int>();
        foreach(var num in nums)
            d[num]=d.ContainsKey(num)?d[num]+1:1;
        var max = d.Max(p=>p.Value);
        return d.Where(p=>p.Value==max).Sum(p=>p.Value);
    }
}
