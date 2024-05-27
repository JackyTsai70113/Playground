namespace playground;

public class DuplicateNumbersXOR3158
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-xor-of-numbers-which-appear-twice
    /// </summary>
    public static int DuplicateNumbersXOR(int[] nums)
    {
        var d = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            d[num] = d.ContainsKey(num) ? d[num] + 1 : 1;
        }
        var res = 0;
        foreach (var num in d.Where(kvp => kvp.Value == 2).Select(kvp => kvp.Key))
        {
            res ^= num;
        }
        return res;
    }
}
