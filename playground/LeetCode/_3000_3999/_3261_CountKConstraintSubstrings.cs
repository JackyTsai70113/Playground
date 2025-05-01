namespace playground._3200_3299;

public class _3261_CountKConstraintSubstrings
{
    public static long[] CountKConstraintSubstrings(string s, int k, int[][] qs)
    {
        int n = s.Length;
        int[] leftCumulative = new int[n];
        int[] rightMost = new int[n];
        int[] count = new int[2];
        bool Valid(int[] count)
        {
            return count[0] <= k || count[1] <= k;
        }
        for (int l = 0, r = 0, sum = 0; r < n; r++)
        {
            count[s[r] - '0']++;
            while (!Valid(count))
            {
                count[s[l] - '0']--;
                l++;
            }
            sum += r - l + 1;
            leftCumulative[r] = sum; // 在 該 index 持續累積的可行數量
        }
        count = new int[2];
        for (int r = n - 1, l = n - 1; l >= 0; l--)
        {
            count[s[l] - '0']++;
            while (!Valid(count))
            {
                count[s[r] - '0']--;
                r--;
            }
            rightMost[l] = r; // 在該 index 最右邊可行的索引
        }
        var res = new long[qs.Length];
        for (int i = 0; i < qs.Length; i++)
        {
            int left = qs[i][0], right = qs[i][1];
            int rightIndex = Math.Min(right, rightMost[left]);
            long len = rightIndex - left + 1;
            res[i] += len * (len + 1) / 2; // 這個範圍內任選都是可行的
            res[i] += leftCumulative[right] - leftCumulative[rightIndex];
        }
        return res;
    }
}
