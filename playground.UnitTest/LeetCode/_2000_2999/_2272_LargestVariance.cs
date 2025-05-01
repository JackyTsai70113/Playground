namespace playground.UnitTest.LeetCode._2000_2999;

public class _2272_LargestVariance
{
    public static int LargestVariance(string s)
    {
        var chs = new int[26];
        for (int i = 0; i < s.Length; i++)
            chs[s[i] - 'a']++;

        int res = 0;
        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (i == j || chs[i] == 0 || chs[j] == 0)
                    continue;
                int iCount = 0, jCount = 0, jRest = chs[j];
                foreach (var c in s)
                {
                    if (c == i + 'a')
                    {
                        iCount++;
                    }
                    else if (c == j + 'a')
                    {
                        jCount++;
                        jRest--;
                    }
                    else
                    {
                        continue;
                    }

                    if (jCount > 0)
                    {
                        res = Math.Max(res, iCount - jCount);
                    }
                    if (iCount < jCount && jRest > 0)
                    {
                        iCount = 0;
                        jCount = 0;
                    }
                }
            }
        }
        return res;
    }
}
