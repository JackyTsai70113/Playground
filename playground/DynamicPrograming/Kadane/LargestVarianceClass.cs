namespace playground.DynamicPrograming.Kadane;

public class LargestVarianceClass
{
    /// <summary>
    /// https://leetcode.com/problems/substring-with-largest-variance
    /// </summary>
    public static int LargestVariance(string s)
    {
        int majorCount, minorCount, restMinorCount, res = 0;
        var counter = new int[26];
        foreach (var c in s)
            counter[c - 'a']++;

        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (i == j || counter[i] == 0 || counter[j] == 0)
                    continue;
                majorCount = 0;
                minorCount = 0;
                restMinorCount = counter[j];

                foreach (var c in s)
                {
                    if (c - 'a' == i)
                        majorCount++;
                    if (c - 'a' == j)
                    {
                        minorCount++;
                        restMinorCount--;
                    }
                    if (minorCount > 0)
                        res = Math.Max(res, majorCount - minorCount);
                    if (majorCount < minorCount && restMinorCount > 0)
                    {
                        majorCount = 0;
                        minorCount = 0;
                    }
                }
            }
        }
        return res;
    }
}
