namespace playground.LeetCode._2000_2999;

public class _2410_MatchPlayersAndTrainers
{
    public static int MatchPlayersAndTrainers(int[] A, int[] B)
    {
        Array.Sort(A);
        Array.Sort(B);
        int i = 0, j = 0, match = 0;
        while (i < A.Length && j < B.Length)
        {
            if (A[i] <= B[j])
            {
                match++;
                i++;
                j++;
            }
            else
            {
                j++;
            }
        }
        return match;
    }
}
