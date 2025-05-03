namespace playground.LeetCode._1000_1999;

public class _1234_BalancedString
{
    public static int BalancedString(string s)
    {
        var count = new Dictionary<char, int>
        {
            { 'Q', 0 }, { 'W', 0 }, { 'E', 0 }, { 'R', 0 }
        };

        int n = s.Length;
        foreach (char c in s)
            count[c]++;

        int limit = n / 4;
        int res = n, left = 0;
        if (count['Q'] == limit &&
            count['W'] == limit &&
            count['E'] == limit &&
            count['R'] == limit)
        {
            return 0;
        }
        for (int right = 0; right < n; right++)
        {
            count[s[right]]--;

            while (left < right &&
                   count[s[left]] + 1 <= limit)
            {
                count[s[left]]++;
                left++;
            }
            if (count['Q'] <= limit &&
                count['W'] <= limit &&
                count['E'] <= limit &&
                count['R'] <= limit)
            {
                res = Math.Min(res, right - left + 1);
            }
        }

        return res;
    }
}
