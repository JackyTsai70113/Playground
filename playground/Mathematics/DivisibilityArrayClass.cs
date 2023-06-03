namespace playground.Mathematics;

public class DivisibilityArrayClass
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-divisibility-array-of-a-string
    /// </summary>
    public static int[] DivisibilityArray(string word, int m)
    {
        int n = word.Length, mlen = m.ToString().Length;
        var res = new int[n];
        int i = mlen - 1;
        while (i < n)
        {
            res[i] = int.Parse(word[..(i + 1)]) % m == 0 ? 1 : 0;
            if (res[i] == 1)
            {
                i += mlen;
            }
            else
            {
                i++;
            }
        }
        return res;
    }
}
