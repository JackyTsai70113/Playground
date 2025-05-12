namespace playground.LeetCode._3000_3999;

public class _3548_CanPartitionGrid
{
    public static bool CanPartitionGrid(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        long sum = 0;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                sum += A[i][j];

        return Check(A, sum, m, n, isRow: true, reverse: false) ||
               Check(A, sum, m, n, isRow: true, reverse: true) ||
               Check(A, sum, m, n, isRow: false, reverse: false) ||
               Check(A, sum, m, n, isRow: false, reverse: true);
    }

    private static bool Check(int[][] A, long sum, int m, int n, bool isRow, bool reverse)
    {
        long partialSum = 0;
        var vals = new HashSet<long>();
        int outerLen = isRow ? m : n;
        int innerLen = isRow ? n : m;

        int start = reverse ? outerLen - 1 : 0;
        int end = reverse ? 0 : outerLen - 1;
        int step = reverse ? -1 : 1;

        for (int i = start; reverse ? i >= end : i < end; i += step)
        {
            AccumulatePartialSumAndVals(A, isRow, i, innerLen, ref partialSum, vals);

            long target = partialSum * 2;
            long diff = target - sum;

            if (target == sum)
                return true;

            bool isFirst = i == start;
            bool isSingleLine = (isRow ? n : m) == 1;

            if (isFirst)
            {
                if (CheckFirstLineEdge(A, isRow, i, diff))
                    return true;
            }
            else if (isSingleLine)
            {
                if (CheckSingleLineEdge(A, isRow, reverse, m, n, i, diff))
                    return true;
            }
            else
            {
                if (vals.Contains(diff))
                    return true;
            }
        }

        return false;
    }

    private static void AccumulatePartialSumAndVals(int[][] A, bool isRow, int outerIdx, int innerLen, ref long partialSum, HashSet<long> vals)
    {
        for (int j = 0; j < innerLen; j++)
        {
            int val = isRow ? A[outerIdx][j] : A[j][outerIdx];
            partialSum += val;
            vals.Add(val);
        }
    }

    private static bool CheckFirstLineEdge(int[][] A, bool isRow, int idx, long diff)
    {
        int edge1 = isRow ? A[idx][0] : A[0][idx];
        int edge2 = isRow ? A[idx][^1] : A[^1][idx];
        return diff == edge1 || diff == edge2;
    }

    private static bool CheckSingleLineEdge(int[][] A, bool isRow, bool reverse, int m, int n, int idx, long diff)
    {
        int fixedIdx = reverse ? (isRow ? m - 1 : n - 1) : 0;
        int edge1 = isRow ? A[fixedIdx][0] : A[0][fixedIdx];
        int edge2 = isRow ? A[idx][0] : A[0][idx];
        return diff == edge1 || diff == edge2;
    }
}
