namespace playground.Arrays;

public class GetWinnerClass
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-winner-of-an-array-game
    /// </summary>
    public static int GetWinner(int[] arr, int k)
    {
        int res = Math.Max(arr[0], arr[1]), count = 1;
        for (int i = 2; i < arr.Length && count < k; ++i)
        {
            if (res > arr[i])
            {
                count++;
            }
            else
            {
                res = arr[i];
                count = 1;
            }
        }
        return res;
    }
}
