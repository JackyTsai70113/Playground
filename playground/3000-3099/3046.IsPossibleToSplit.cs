namespace playground;

public class IsPossibleToSplit3046
{
    /// <summary>
    /// https://leetcode.com/problems/split-the-array
    /// </summary>
    public static bool IsPossibleToSplit(int[] nums)
    {
        var d = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            d[num] = d.ContainsKey(num) ? d[num] + 1 : 1;
            if (d[num] > 2)
                return false;
        }
        return true;
    }
}
