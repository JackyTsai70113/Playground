namespace playground._2300_2399;

public class _2381_ShiftingLetters
{
    public static string ShiftingLetters(string s, int[][] shifts)
    {
        var presum = new int[s.Length + 1];
        foreach (var shift in shifts)
        {
            int val = shift[2] == 1 ? 1 : -1;
            presum[shift[0]] += 26 + val;
            presum[shift[1] + 1] += 26 - val;
        }
        var chs = new char[s.Length];
        for (int i = 0, cur = 0; i < s.Length; i++)
        {
            cur += presum[i];
            chs[i] = (char)((s[i] - 'a' + cur) % 26 + 'a');
        }
        return new string(chs);
    }
}
