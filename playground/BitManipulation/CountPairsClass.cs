using playground.TreeNodes;

namespace playground.BitManipulation;

public class CountPairsClass
{
    const int LEVEL = 14;
    /// <summary>
    /// https://leetcode.com/problems/count-pairs-with-xor-in-a-range
    /// </summary>
    public static int CountPairs(int[] nums, int low, int high)
    {
        var count = 0;
        var trie = new Trie();
        foreach (var num in nums)
        {
            count += trie.CountSmallerPairs(num, high + 1) - trie.CountSmallerPairs(num, low);
            trie.Insert(num);
        }
        return count;
    }

    private class Trie
    {
        private readonly TreeNode<int> root = new();

        public void Insert(int num)
        {
            var cur = root;
            for (int i = LEVEL; i >= 0 && cur != null; --i)
            {
                var nBit = (num & (1 << i)) > 0 ? 1 : 0;
                if (!cur.TryGetChild(nBit, out var child))
                {
                    cur.AddChild(nBit);
                    child = cur.GetChild(nBit);
                }
                cur = child;
                cur.SetValue(cur.GetValue() + 1);
            }
        }

        public int CountSmallerPairs(int num, int k)
        {
            var count = 0;
            var cur = root;
            for (int i = LEVEL; i >= 0 && cur != null; --i)
            {
                var nBit = (num & (1 << i)) > 0 ? 1 : 0;
                var kBit = (k & (1 << i)) > 0 ? 1 : 0;

                if (kBit == 0)
                {
                    if (cur.TryGetChild(nBit, out var child))
                        // 繼續找和 nBit 一樣的 bit
                        cur = child;
                    else
                        break;
                }
                else
                {
                    // 若含和 nBit 一樣的 bit，則加進 count
                    if (cur.TryGetChild(nBit, out var child))
                        count += child.GetValue();
                    // 繼續找和 nBit 不一樣的 bit
                    cur = cur.GetChild(1 - nBit);
                }
            }
            return count;
        }
    }
}
