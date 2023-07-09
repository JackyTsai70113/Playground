namespace playground.Sets;

public class RelocateMarblesClass
{
    /// <summary>
    /// https://leetcode.com/problems/relocate-marbles
    /// </summary>
    public static IList<int> RelocateMarbles(int[] nums, int[] f, int[] t)
    {
        var s = new HashSet<int>(nums);
        for (int i = 0; i < f.Length; ++i)
        {
            s.Remove(f[i]);
            s.Add(t[i]);
        }
        return s.ToList().OrderBy(x => x).ToList();
    }
}
