namespace playground.LeetCode._1000_1999;

public class _1535_GetWinner
{
    public static int GetWinner(int[] arr, int k)
    {
        int winner = arr[0], count = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (winner > arr[i])
            {
                count++;
            }
            else
            {
                winner = arr[i];
                count = 1;
            }
            if (count == k) break;
        }
        return winner;
    }
}
