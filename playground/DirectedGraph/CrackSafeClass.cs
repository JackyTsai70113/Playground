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

        void dfs(string str){
            for (int i = k-1; i >=0; --i){
                var cur = str+i;
                if(!s.Contains(cur)){
                    s.Add(cur);
                    res.Append(i);
                    dfs(cur[1..]);
                }
            }
        }
        for (int i = 0; i < n - 1; ++i){
            res.Append(0);
        }
        dfs(res.ToString());
        return res.ToString();
    }
}
