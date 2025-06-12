namespace playground.LeetCode._3000_3999;

public class _3577_CountPermutations
{
    public static int CountPermutations(int[] A)
    {
        long MOD = (long)1e9 + 7;

        int n = A.Length;
        var arr = A
            .Select((x, i) => (x, i))
            .OrderBy(y => y.x)
            .ThenBy(y => y.i)
            .ToArray();
        if (arr[0].i != 0 || arr[0].x == arr[1].x) return 0;

        int idx = 1;
        long res = 1, slots = 1;
        while (idx < n)
        {
            int curCount = 0;
            int curVal = arr[idx].x;
            while (idx < n && arr[idx].x == curVal)
            {
                curCount++;
                idx++;
            }
            for (int i = 0; i < curCount; i++)
            {
                res = res * (slots + i) % MOD;
            }
            slots += curCount;
        }
        return (int)res;
    }
}
