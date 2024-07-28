namespace playground;

public class MinimumCost2976
{
    public static long MinimumCost(string source, string target, char[] A, char[] B, int[] cost)
    {
        var distance = new long[26, 26];
        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                distance[i, j] = i == j ? 0 : int.MaxValue;
            }
        }
        for (int i = 0; i < A.Length; ++i)
        {
            distance[A[i] - 'a', B[i] - 'a'] = Math.Min(distance[A[i] - 'a', B[i] - 'a'], cost[i]);
        }
        for (int k = 0; k < 26; k++)
        {
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (distance[i, k] == int.MaxValue)
                        continue;
                    if (distance[k, j] == int.MaxValue)
                        continue;
                    distance[i, j] = Math.Min(distance[i, j], distance[i, k] + distance[k, j]);
                }
            }
        }
        long res = 0;
        for (int i = 0; i < source.Length; i++)
        {
            if (distance[source[i] - 'a', target[i] - 'a'] == int.MaxValue)
                return -1;
            res += distance[source[i] - 'a', target[i] - 'a'];
        }
        return res;
    }
}
