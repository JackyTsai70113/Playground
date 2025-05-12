namespace playground.LeetCode._3000_3999;

public class _3546_CanPartitionGrid
{
    public static bool CanPartitionGrid(int[][] A)
    {
        int m = A.Length, n = A[0].Length;
        long sum = 0;
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                sum+=A[i][j];
            }
        }

        if(sum%2 != 0)
            return false;
        long partialSum = 0;
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                partialSum += A[i][j];
            }
            if(partialSum * 2 == sum)
                return true;
        }

        partialSum = 0;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                partialSum += A[j][i];
            }
            if(partialSum * 2 == sum)
                return true;
        }
        return false;
    }
}
