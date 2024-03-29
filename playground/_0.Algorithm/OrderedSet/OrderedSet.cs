namespace playground;

public class OrderedSet
{
    public static int[] GetViewBetween(int[] arr, int l, int r)
    {
        var sortedSet = new SortedSet<int>(arr);
        return sortedSet.GetViewBetween(l, r).ToArray();
    }
}
