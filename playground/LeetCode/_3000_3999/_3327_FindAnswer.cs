using playground._0.Algorithm;

namespace playground.LeetCode._3000_3999;

public class _3327_FindAnswer
{
    char[] dfsStr;
    public bool[] FindAnswer(int[] parent, string s)
    {
        int n = parent.Length;
        var g = new List<int>[n];
        for (int i = 0; i < n; i++) g[i] = new();
        for (int i = 1; i < parent.Length; i++)
        {
            g[parent[i]].Add(i);
        }
        List<(int index, int length, int node)> values = new();
        void Dfs(int node, ref int index)
        {
            int start = index;
            foreach (var child in g[node])
            {
                Dfs(child, ref index);
            }
            dfsStr[index++] = s[node];
            int end = index - 1;
            int length = end - start + 1;
            int mid = (start + end) / 2;
            values.Add((start + end + 1, length, node));
        }
        dfsStr = new char[n];
        bool[] res = new bool[n];
        int index = 0;
        Dfs(0, ref index);
        // Apply Manacher's algorithm on the DFS traversal string
        int[] manacherLengths = LongestPalindromicSubstring.Manacher(new string(dfsStr));

        // Check odd-length palindromes
        foreach (var (i, length, node) in values)
        {
            if (manacherLengths[i] >= length)
            {
                res[node] = true;
            }
        }
        return res;
    }
}
