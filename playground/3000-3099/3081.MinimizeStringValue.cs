namespace playground;

public class MinimizeStringValue3081
{
    /// <summary>
    /// https://leetcode.com/problems/replace-question-marks-in-string-to-minimize-its-value
    /// </summary>
    public static string MinimizeStringValue(string s)
    {
        var count = new int[26];
        var l = new List<char>();
        foreach (var c in s)
            if (c != '?')
                count[c - 'a']++;
        foreach (var c in s)
        {
            if (c != '?') continue;
            int minFreqIndex = 0, minFreq = int.MaxValue;
            for (int i = 0; i < 26; i++)
            {
                if (count[i] < minFreq)
                {
                    minFreq = count[i];
                    minFreqIndex = i;
                }
            }
            count[minFreqIndex]++;
            l.Add((char)(minFreqIndex + 'a'));
        }
        l.Sort((x, y) => x - y);
        var res = s.ToCharArray();
        for (int i = 0, j = 0; i < res.Length; i++)
        {
            if (res[i] == '?')
                res[i] = l[j++];
        }
        return new string(res);
    }
}
