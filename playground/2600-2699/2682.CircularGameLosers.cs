namespace playground;

public class CircularGameLosers_2682
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-losers-of-the-circular-game
    /// </summary>
    public static int[] CircularGameLosers(int n, int k)
    {
        var set = new HashSet<int>(Enumerable.Range(0, n));
        set.Remove(0);
        for (int i = 0, j = 1; ; j++)
        {
            i = (i + j * k) % n;
            if (!set.Remove(i))

            {
                break;
            }
        }
        return set.Select(i => i + 1).ToArray();
    }
}
