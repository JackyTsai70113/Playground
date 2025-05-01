namespace playground;

public class _1803_CountPairs
{
    /// <summary>
    /// https://leetcode.com/problems/count-pairs-with-xor-in-a-range
    /// </summary>
    public static int CountPairs(int[] nums, int low, int high)
    {
        int res = 0;
        // val: count, children: 0, 1
        TrieNode<int> root = new(0, new TrieNode<int>[2]);
        foreach (var num in nums)
        {
            res += CountPairs(root, num, high + 1) - CountPairs(root, num, low);
            Insert(root, num);
        }
        return res;
    }

    /// <summary>
    /// 取得高於 high 的 pair
    /// </summary>
    private static int CountPairs(TrieNode<int> root, int num, int high)
    {
        int count = 0;
        var cur = root;
        for (int i = 14; i >= 0 && cur != null; i--)
        {
            var numBit = (num >> i) & 1;
            var highBit = (high >> i) & 1;

            if (highBit == 0)
            {
                // if bit of high == 0, XOR result only can be 0.
                // go to bit which is same as num.
                cur = cur.children[numBit];
            }
            else
            {
                // if bit of high == 1, XOR can be 0 or 1. 
                // add 0 side, which mean that bit same as num
                // and go for 1, which mean that bit differenct from num
                if (cur.children[numBit] != null)
                    count += cur.children[numBit].val;
                cur = cur.children[1 - numBit];
            }
        }
        return count;
    }

    private static void Insert(TrieNode<int> root, int num)
    {
        var cur = root;
        for (int i = 14; i >= 0; i--)
        {
            var numBit = (num >> i) & 1;

            if (cur.children[numBit] == null)
                cur.children[numBit] = new(0, new TrieNode<int>[2]); ;
            cur = cur.children[numBit];
            cur.val++;
        }
    }
}
