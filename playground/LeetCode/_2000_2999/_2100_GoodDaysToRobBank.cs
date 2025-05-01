namespace playground.LeetCode._2000_2999;

public class _2100_GoodDaysToRobBank
{
    public static IList<int> GoodDaysToRobBank(int[] A, int time)
    {
        int n = A.Length;
        if (n <= time * 2) return new List<int>();
        if (time == 0) return Enumerable.Range(0, n).ToArray();
        int before = 0, after = 0;
        for (int i = 0; i < time - 1; i++)
        {
            before = A[i] >= A[i + 1] ? before + 1 : 0;
        }

        for (int i = time; i < time * 2 - 1; i++)
        {
            after = A[i] <= A[i + 1] ? after + 1 : 0;
        }

        var l = new List<int>();
        for (int i = time; i <= n - time - 1; i++)
        {
            before = A[i - 1] >= A[i] ? before + 1 : 0;
            after = A[i + time - 1] <= A[i + time] ? after + 1 : 0;
            if (before >= time && after >= time)
                l.Add(i);
        }
        return l;
    }
}
