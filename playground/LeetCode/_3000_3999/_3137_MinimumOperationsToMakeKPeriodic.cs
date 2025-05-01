namespace playground;

public class _3137_MinimumOperationsToMakeKPeriodic
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-operations-to-make-word-k-periodic
    /// </summary>
    public static int MinimumOperationsToMakeKPeriodic(string word, int k)
    {
        var d = new Dictionary<string, int>();
        int max = 0;
        for (int i = 0; i < word.Length; i += k)
        {
            var str = word.Substring(i, k);
            d[str] = d.ContainsKey(str) ? d[str] + 1 : 1;
            max = Math.Max(max, d[str]);
        }
        return word.Length / k - max;
    }
}
