namespace playground.LeetCode._2000_2999;

public class _2942_FindWordsContaining
{
    /// <summary>
    /// https://leetcode.com/problems/find-words-containing-character
    /// </summary>
    public static IList<int> FindWordsContaining(string[] A, char x)
    {
        var res = new List<int>();
        for (int i = 0; i < A.Length; ++i)
        {
            if (A[i].IndexOf(x) > -1)
            {
                res.Add(i);
            }
        }
        return res;
    }
}
