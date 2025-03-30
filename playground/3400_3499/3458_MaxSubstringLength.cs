namespace playground._3400_3499;

public class _3458_MaxSubstringLength
{
    public static bool MaxSubstringLength(string s, int k)
    {
        if (k == 0)
            return true;
        int n = s.Length;
        int[] first = new int[26], last = new int[26];
        Array.Fill(first, -1);
        var counts = new int[26];
        for (int i = 0; i < n; i++)
        {
            int c = s[i] - 'a';
            if (first[c] == -1) first[c] = i;
            last[c] = i;
        }

        var valids = new List<int[]>();
        for (int i = 0; i < 26; i++)
        {
            if (first[i] == -1) continue;
            int curFarest = last[i];
            bool valid = true;

            for (int j = first[i]; j <= curFarest; j++)
            {
                if (first[s[j] - 'a'] < first[i])
                {
                    valid = false;
                    break;
                }
                curFarest = Math.Max(curFarest, last[s[j] - 'a']);
            }
            if (!valid || first[i] == 0 && curFarest == n - 1) continue;
            valids.Add(new int[] { first[i], curFarest });
        }
        int count = 0, curEnd = -1;
        valids.Sort((x, y) => x[1] - y[1]);
        for (int i = 0; i < valids.Count; i++)
        {
            if (valids[i][0] > curEnd)
            {
                count++;
                curEnd = valids[i][1];
            }
        }
        return count >= k;
    }
}
