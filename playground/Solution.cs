using System.Net;

namespace playground;

public class Solution
{
    // public int MinimumCost(string target, string[] words, int[] costs)
    // {
    //     var d = new Dictionary<string, int>();
    //     var countD = new HashSet<int>();
    //     var seen = new Dictionary<string, int> { [""] = 0 };
    //     for (int i = 0; i < words.Length; i++)
    //     {
    //         if (d.ContainsKey(words[i]))
    //             d[words[i]] = Math.Min(d[words[i]], costs[i]);
    //         else
    //             d[words[i]] = costs[i];
    //         countD.Add(words[i].Length);
    //     }
    //     for (int i = 0; i < target.Length; i++)
    //     {
    //         foreach (var len in countD)
    //         {
    //             if (i + len <= target.Length)
    //             {
    //                 if ((i == 0 || seen.ContainsKey(target[..i])) && d.ContainsKey(target.Substring(i, len)))
    //                 {
    //                     var str = target.Substring(i, len);
    //                     seen[target[..i] + str] = seen.ContainsKey(target[..i] + str) ? Math.Min(seen[target[..i] + str], seen[target[..i]] + d[str]) : seen[target[..i]] + d[str];
    //                 }
    //             }
    //         }
    //     }
    //     return seen.ContainsKey(target) ? seen[target] : -1;
    // }

    // private void Dfs2(string target, Dictionary<string, int> d, string str, int cur, int[] res)
    // {
    //     if (str.Length == target.Length)
    //     {
    //         res[0] = Math.Min(res[0], cur);
    //         return;
    //     }
    //     var max = d.Keys.Select(k => k.Length).Max();
    //     for (int len = 1; len <= max && str.Length + len <= target.Length; len++)
    //     {
    //         var s = target.Substring(str.Length, len);
    //         if (d.ContainsKey(s))
    //         {
    //             Dfs2(target, d, str + s, cur + d[s], res);
    //         }
    //     }
    // }
}