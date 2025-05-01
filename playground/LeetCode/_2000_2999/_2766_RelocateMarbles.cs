namespace playground.LeetCode._2000_2999;

public class _2766_RelocateMarbles
{
    /// <summary>
    /// https://leetcode.com/problems/relocate-marbles
    /// </summary>
    public static IList<int> RelocateMarbles(int[] nums, int[] moveFrom, int[] moveTo)
    {
        var s = nums.ToHashSet();
        for (int i = 0; i < moveFrom.Length; i++)
        {
            s.Remove(moveFrom[i]);
            s.Add(moveTo[i]);
        }
        return s.ToList().OrderBy(x => x).ToList();
    }
}
