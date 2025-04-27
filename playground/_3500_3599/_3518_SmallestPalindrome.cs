using System.Numerics;

namespace playground._3500_3599;

public class _3518_SmallestPalindrome
{
    const int MAX = 10005;
    BigInteger[] fact = new BigInteger[MAX];

    public string SmallestPalindrome(string s, int k)
    {
        // 建立半邊頻率
        int[] halfFreq = new int[26];
        int halfLen = s.Length / 2;
        char mid = s.Length % 2 == 1 ? s[s.Length / 2] : '\0';
        for (int i = 0; i < s.Length / 2; i++)
        {
            halfFreq[s[i] - 'a']++;
        }

        // 預先計算 factorial
        PrecomputeFactorials(halfLen);

        // 計算總排列數
        BigInteger total = GetTotalPerms(halfFreq, halfLen);
        if (total < k) return "";

        // 構造結果
        List<char> halfResult = new List<char>();
        for (int i = 0; i < halfLen; i++)
        {
            for (int c = 0; c < 26; c++)
            {
                if (halfFreq[c] == 0) continue;

                halfFreq[c]--;
                BigInteger count = GetTotalPerms(halfFreq, halfLen - i - 1);

                if (count >= k)
                {
                    halfResult.Add((char)(c + 'a'));
                    break;
                }
                else
                {
                    k -= (int)count;
                    halfFreq[c]++;
                }
            }
        }

        // 組合回文
        string left = new string(halfResult.ToArray());
        string right = new string(halfResult.AsEnumerable().Reverse().ToArray());
        return mid == '\0' ? left + right : left + mid + right;
    }

    void PrecomputeFactorials(int n)
    {
        fact[0] = 1;
        for (int i = 1; i <= n; i++)
            fact[i] = fact[i - 1] * i;
    }

    BigInteger GetTotalPerms(int[] freq, int len)
    {
        BigInteger res = fact[len];
        foreach (int count in freq)
        {
            if (count > 1)
                res /= fact[count];
        }
        return res;
    }
}
