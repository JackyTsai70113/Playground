namespace playground;

public class _3285_StableMountains
{
    public static IList<int> StableMountains(int[] height, int threshold)
    {
        var l = new List<int>();
        for (int i = 1; i < height.Length; i++)
        {
            if (height[i - 1] > threshold)
                l.Add(i);
        }
        return l;
    }
}
