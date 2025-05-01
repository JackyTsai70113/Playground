using System.Text;

namespace playground.LeetCode._0000_0999;

public class _0767_ReorganizeString
{
    public static string ReorganizeString(string s)
    {
        var count = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
        }
        var pq = new PriorityQueue<int, int>();
        for (int i = 0; i < 26; i++)
        {
            if (count[i] > 0)
                pq.Enqueue(i, -count[i]);
        }
        var sb = new StringBuilder();
        while (pq.Count > 0)
        {
            var index = pq.Dequeue();
            if (sb.Length > 0 && sb[^1] == (char)(index + 'a'))
            {
                if (pq.Count > 0)
                {
                    var index2 = pq.Dequeue();
                    sb.Append((char)(index2 + 'a'));
                    count[index2]--;
                    if (count[index2] > 0)
                        pq.Enqueue(index2, -count[index2]);
                }
                else
                {
                    return "";
                }
            }

            sb.Append((char)(index + 'a'));
            count[index]--;
            if (count[index] > 0)
                pq.Enqueue(index, -count[index]);
        }
        return sb.ToString();
    }
}
