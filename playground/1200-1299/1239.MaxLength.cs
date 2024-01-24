using System.Numerics;

namespace playground;

public class MaxLength1239
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters
    /// </summary>
    public static int MaxLength(IList<string> arr)
    {
        arr = arr
            .Where(s => s.Distinct().Count() == s.Length)
            .Distinct()
            .ToList();
        int ToMask(string s)
        {
            int mask = 0;
            foreach (var c in s)
                mask |= 1 << (c - 'a');
            return mask;
        }
        var q = new Queue<(int mask, int index)>();
        for (int i = 0; i < arr.Count; i++)
            q.Enqueue((ToMask(arr[i]), i));
        int res = 0;
        while (q.Count > 0)
        {
            var (mask, idx) = q.Dequeue();
            res = Math.Max(res, BitOperations.PopCount((uint)mask));
            for (int j = idx + 1; j < arr.Count; j++)
            {
                int vMask = ToMask(arr[j]);
                if ((mask | vMask) == mask + vMask)
                    q.Enqueue((mask | vMask, j));
            }
        }
        return res;
    }
}
