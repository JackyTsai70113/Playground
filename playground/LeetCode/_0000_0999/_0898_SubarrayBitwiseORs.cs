namespace playground.LeetCode._0000_0999;

public class _0898_SubarrayBitwiseORs
{
    public static int SubarrayBitwiseORs(int[] arr)
    {
        var set = new HashSet<long>();
        var set1 = new HashSet<long>();
        var set2 = new HashSet<long>();
        foreach (long num in arr)
        {
            set2.Clear();
            foreach (var element in set1)
            {
                set2.Add(element | num);
            }
            set2.Add(num);
            (set1, set2) = (set2, set1);

            foreach (long element in set1)
            {
                set.Add(element);
            }
        }
        return set.Count;
    }
}
