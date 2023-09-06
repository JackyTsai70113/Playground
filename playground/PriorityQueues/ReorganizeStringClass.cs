using System.Text;

namespace playground.PriorityQueues;

public class ReorganizeStringClass
{
    /// <summary>
    /// https://leetcode.com/problems/reorganize-string/
    /// </summary>
    public static string ReorganizeString(string s)
    {
        var charCounts = new int[26];
        foreach (var c in s)
            charCounts[c - 'a']++;
        var pq = new PriorityQueue<char, int>();
        for (int i = 0; i < 26; ++i)
        {
            if (charCounts[i] > 0)
                pq.Enqueue((char)(i + 'a'), -charCounts[i]);
        }
        StringBuilder sb = new();
        while (pq.Count > 0)
        {
            var first = pq.Dequeue();
            if (sb.Length == 0 || sb[^1] != first)
            {
                sb.Append(first);

                if (--charCounts[first - 'a'] > 0)
                    pq.Enqueue(first, -charCounts[first - 'a']);
            }
            else
            {
                if (pq.Count == 0)
                    return "";
                var second = pq.Dequeue();
                sb.Append(second);
                if (--charCounts[second - 'a'] > 0)
                    pq.Enqueue(second, -charCounts[second - 'a']);
                pq.Enqueue(first, -charCounts[first - 'a']);
            }
        }
        return sb.ToString();
    }
}
