namespace playground;

public class _3147_MaximumEnergy
{
    /// <summary>
    /// https://leetcode.com/problems/taking-maximum-energy-from-the-mystic-dungeon
    /// </summary>
    public static int MaximumEnergy(int[] A, int k)
    {
        int res = int.MinValue;
        for (int i = A.Length - 1; i >= 0; i--)
        {
            if (i + k < A.Length)
            {
                A[i] += A[i + k];
            }
            res = Math.Max(res, A[i]);
        }
        return res;
    }
}
