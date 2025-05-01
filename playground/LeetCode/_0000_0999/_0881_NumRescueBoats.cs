namespace playground.LeetCode._0000_0999;

public class _0881_NumRescueBoats
{
    /// <summary>
    /// https://leetcode.com/problems/boats-to-save-people
    /// </summary>
    public static int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);
        int res = 0;
        for (int l = 0, r = people.Length - 1; l <= r; r--)
        {
            int boat = people[r];
            if (boat + people[l] <= limit)
            {
                l++;
            }
            res++;
        }
        return res;
    }
}
