using System.Text;

namespace playground.TwoPointers;

public class LargestMergeClass
{
    /// <summary>
    /// https://leetcode.com/problems/largest-merge-of-two-strings
    /// </summary>
    public static string LargestMerge(string s1, string s2)
    {
        return LargestMerge(s1, s2, 0, 0, new int[s1.Length + 1, s2.Length + 1]);
    }

    private static string LargestMerge(string s1, string s2, int i, int j, int[,] memo)
    {
        if (i == s1.Length)
            return s2[j..];
        if (j == s2.Length)
            return s1[i..];
        bool isALarger(int i, int j)
        {
            if (i >= s1.Length && j >= s2.Length) return true;
            if (memo[i, j] > 0) return memo[i, j] > 1;
            var ch1 = i < s1.Length ? s1[i] : 'a' - 1;
            var ch2 = j < s2.Length ? s2[j] : 'a' - 1;
            if (ch1 > ch2)
            {
                memo[i, j] = 2;
                return true;
            }
            else if (ch1 < ch2)
            {
                memo[i, j] = 1;
                return false;
            }
            if (isALarger(i + 1, j + 1))
            {
                memo[i, j] = 2;
            }
            else
            {
                memo[i, j] = 1;
            }
            return memo[i, j] > 1;
        }
        if (isALarger(i, j))
        {
            return s1[i] + LargestMerge(s1, s2, i + 1, j, memo);
        }
        else
        {
            return s2[j] + LargestMerge(s1, s2, i, j + 1, memo);
        }
    }

    public static string LargestMerge1(string s1, string s2)
    {
        if (s1.Length == 0 || s2.Length == 0)
            return s1 + s2;
        if (s1.CompareTo(s2) > 0)
        {
            return s1[0] + LargestMerge1(s1[1..], s2);
        }
        return s2[0] + LargestMerge1(s1, s2[1..]);
    }

    public static string LargestMerge2(string s1, string s2)
    {
        int i = 0, j = 0, n1 = s1.Length, n2 = s2.Length;
        var sb = new StringBuilder();
        while (i < n1 && j < n2)
        {
            if (s1[i] > s2[j])
            {
                sb.Append(s1[i++]);
            }
            else if (s1[i] < s2[j])
            {
                sb.Append(s2[j++]);
            }
            else
            {
                int ii = i, jj = j;
                while (ii < n1 && jj < n2 && s1[ii] == s2[jj])
                {
                    ii++;
                    jj++;
                }
                if (ii < n1 && jj < n2)
                {
                    if (s1[ii] > s2[jj])
                    {
                        sb.Append(s1[i++]);
                    }
                    else if (s1[ii] < s2[jj])
                    {
                        sb.Append(s2[j++]);
                    }
                }
                else if (ii < n1)
                {
                    sb.Append(s1[i++]);
                }
                else
                {
                    sb.Append(s2[j++]);
                }
            }
        }
        while (i < n1)
        {
            sb.Append(s1[i++]);
        }
        while (j < n2)
        {
            sb.Append(s2[j++]);
        }
        return sb.ToString();
    }
}
