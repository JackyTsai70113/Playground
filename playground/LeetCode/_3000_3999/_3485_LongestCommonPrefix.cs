namespace playground.LeetCode._3000_3999;

public class _3485_LongestCommonPrefix
{
    public static int[] LongestCommonPrefix(string[] words, int k)
    {
        var dovranimex = words;
        int n = dovranimex.Length;
        int[] answer = new int[n];

        // 將所有單字插入 Trie
        Trie trie = new Trie(k);
        foreach (var word in dovranimex)
        {
            trie.Insert(word);
        }

        // 依序處理每個 index：移除、查詢、再插入回來
        for (int i = 0; i < n; i++)
        {
            trie.Remove(dovranimex[i]);
            answer[i] = trie.Query();
            trie.Insert(dovranimex[i]);
        }

        return answer;
    }
}
public class TrieNode
{
    public TrieNode[] Children = new TrieNode[26];
    public int Count = 0;
    public int Depth = 0;      // 該節點的深度，root 為 0
    public int MaxValid = 0;   // 該子樹中滿足 count >= threshold 的最大前綴長度（不滿足則標記為 -1）
}

public class Trie
{
    public TrieNode Root = new TrieNode();
    private int threshold; // k 值

    public Trie(int k)
    {
        threshold = k;
        Root.Depth = 0;
        // 若尚未達到 threshold，則設為 -1
        Root.MaxValid = -1;
    }

    // 沿著給定的路徑，自底向上更新每個節點的 MaxValid 屬性
    private void UpdatePath(List<TrieNode> path)
    {
        for (int i = path.Count - 1; i >= 0; i--)
        {
            TrieNode node = path[i];
            int newMax;
            if (node.Count < threshold)
            {
                // 此節點不符合條件，無法延伸有效前綴
                newMax = node.Depth - 1;
            }
            else
            {
                newMax = node.Depth;
                // 檢查所有子節點
                for (int j = 0; j < 26; j++)
                {
                    TrieNode child = node.Children[j];
                    if (child != null)
                    {
                        newMax = Math.Max(newMax, child.MaxValid);
                    }
                }
            }
            node.MaxValid = newMax;
        }
    }

    // 插入單字並更新沿途的 augmented 資訊
    public void Insert(string word)
    {
        TrieNode node = Root;
        List<TrieNode> path = new List<TrieNode>();
        path.Add(node);
        node.Count++;
        foreach (char c in word)
        {
            int idx = c - 'a';
            if (node.Children[idx] == null)
            {
                node.Children[idx] = new TrieNode();
                node.Children[idx].Depth = node.Depth + 1;
            }
            node = node.Children[idx];
            path.Add(node);
            node.Count++;
        }
        UpdatePath(path);
    }

    // 移除單字並更新沿途的 augmented 資訊
    public void Remove(string word)
    {
        TrieNode node = Root;
        List<TrieNode> path = new List<TrieNode>();
        path.Add(node);
        node.Count--;
        foreach (char c in word)
        {
            int idx = c - 'a';
            node = node.Children[idx];
            path.Add(node);
            node.Count--;
        }
        UpdatePath(path);
    }

    // 直接透過 Root 的 MaxValid 得到查詢結果（若剩餘字串不足 k 則回傳 0）
    public int Query()
    {
        return Math.Max(0, Root.MaxValid);
    }
}
