namespace playground.LeetCode._2000_2999;

public class _2040_KthSmallestProduct
{
    public static long KthSmallestProduct(int[] A, int[] B, long k)
    {
        // 將正值跟負值分開來
        var (A1, A2) = Split(A);
        var (B1, B2) = Split(B);

        // 設定k, s
        // k依照正負數的組合來調整
        // s是答案的正負, 1表示正數, -1表示負數
        int s;
        long negCount = A1.Count * B2.Count + B1.Count * A2.Count;
        if (k > negCount)
        {
            k -= negCount;
            s = 1;
        }
        else
        {
            k = negCount - k + 1;
            s = -1;
            (B1, B2) = (B2, B1);
        }

        // 二分搜尋尋找數量大於等於k的最小乘積值
        long l = 0, r = (long)1e10;
        while (l < r)
        {
            long mid = l + (r - l) / 2;
            long count = GetCount(A1, B1, mid) + GetCount(A2, B2, mid);
            if (count >= k)
                r = mid;
            else
                l = mid + 1;
        }
        return l * s;
    }

    // 計算A和B的乘積小於等於x的數量
    // 使用雙指針法
    // A和B都已經是正數或負數的情況
    // A和B的長度可能不同
    // 如果A[i] * B[j] > x, 那麼B[0:j]的所有值都會大於x, 所以可以直接減少j
    // 如果A[i] * B[j] <= x, 那麼B[0]到B[j]的所有值都會小於等於x, 所以可以增加計數
    // 這樣可以在O(n + m)的時間內計算出結果
    // A和B的長度分別為n和m, 那麼時間複雜度為O(n + m)
    // 空間複雜度為O(1), 因為只使用了常數級別的額外空間
    // 這個方法的關鍵在於利用了乘積的單調性
    // 
    static long GetCount(List<long> A, List<long> B, long x)
    {
        long res = 0;
        int j = B.Count - 1;
        foreach (var a in A)
        {
            while (j >= 0 && a * B[j] > x)
            {
                j--;
            }
            res += j + 1;
        }
        return res;
    }

    // 將數組中的正數和負數分開
    static (List<long> neg, List<long> post) Split(int[] nums)
    {
        List<long> neg = new(), post = new();
        foreach (var num in nums)
        {
            if (num < 0) neg.Add(-num);
            else post.Add(num);
        }
        neg.Reverse();
        return (neg, post);
    }
}
