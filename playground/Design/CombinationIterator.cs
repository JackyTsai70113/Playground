using System.Text;

namespace playground.Design;

/// <summary>
/// https://leetcode.com/problems/iterator-for-combination
/// </summary>
public class CombinationIterator
{
    readonly string s;
    private readonly int m;
    private readonly int n;
    private int mask;
    bool hasNext;

    public CombinationIterator(string characters, int combinationLength)
    {
        s = characters;
        m = s.Length;
        n = combinationLength;
        mask = ((1 << n) - 1) << m - n;
        hasNext = true;
    }

    public string Next()
    {
        var res = new StringBuilder();
        for (int i = 0; i < m; ++i)
        {
            if ((mask & (1 << m - i - 1)) > 0)
            {
                res.Append(s[i]);
            }
        }
        UpdateMask();
        return res.ToString();
    }

    // can be optimized by Gosper's hack.
    private void UpdateMask()
    {
        // 取最右邊的 1, ex: 6(0110) & -6(1010) = 2(10)
        var rightMostBit = mask & -mask;
        if (rightMostBit != 1)
        {
            // 最右邊是 0, 直接將最右邊的 1 向右移動
            mask ^= rightMostBit;
            mask |= rightMostBit >> 1;
        }
        else
        {
            // 確認是否所有的 1 都在最右邊, 是的話返回
            if ((mask & mask + 1) == 0)
            {
                hasNext = false;
                return;
            }
            // 10011 => 01110
            // 先將最右邊的 1 歸零並記錄: 10011 => 10000
            int oneCount = 0, pos = 0;
            while ((mask & 1 << pos) > 0)
            {
                mask ^= 1 << pos;
                oneCount++; pos++;
            }
            // 此時的 pos 位置數字是 0, 重新找最右邊的 1, 並向右移動: 10000 => 01000
            rightMostBit = mask & -mask;
            mask ^= rightMostBit;
            rightMostBit >>= 1;
            mask |= rightMostBit;
            // 剩下的 1 補上: 01000 => 01110
            while (pos > 0)
            {
                rightMostBit >>= 1;
                mask |= rightMostBit;
                pos--;
            }
        }
    }
    public bool HasNext()
    {
        return hasNext;
    }
}

/**
 * Your CombinationIterator object will be instantiated and called as such:
 * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
 * string param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
