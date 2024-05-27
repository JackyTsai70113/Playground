namespace playground;

public class RelocateMarbles2766
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
