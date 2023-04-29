using System.Text;

namespace playground.DirectedGraph;

public class CrackSafeClass
{
    /// <remarks>https://leetcode.com/problems/cracking-the-safe</remarks>
    public static string CrackSafe(int n, int k)
    {
        var res = new StringBuilder();
        var cur = new StringBuilder();
        HashSet<string> s = new();

        void dfs(StringBuilder sb){
            for (int i = 0; i < k; ++i){
                cur!.Append(i);
                if(!s.Contains(cur.ToString())){
                    s.Add(cur.ToString());
                    res!.Append(i);
                    cur.Remove(cur.Length - 1, 1);
                    dfs(cur);
                }
            }
        }
        for (int i = 0; i < n - 1; ++i){
            res.Append(0);
            cur.Append(0);
        }
        dfs(cur);
        return res.ToString();
    }
}
