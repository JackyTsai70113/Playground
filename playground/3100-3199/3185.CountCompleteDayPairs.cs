namespace playground;

public class CountCompleteDayPairs3185
{
    /// <summary>
    /// https://leetcode.com/problems/count-pairs-that-form-a-complete-day-ii
    /// </summary>
    public static long CountCompleteDayPairs(int[] hours)
    {
        var d = new Dictionary<int, int>();
        long res = 0;
        for (int i = 0; i < hours.Length; i++)
        {
            var cur = hours[i] % 24;
            if (cur != 0 && d.ContainsKey(24 - cur))
                res += d[24 - cur];
            else if (cur == 0 && d.ContainsKey(0))
                res += d[0];
            d[cur] = d.ContainsKey(cur) ? d[cur] + 1 : 1;
        }
        return res;
    }
}
