namespace playground;

public class TriangleType3024
{
    /// <summary>
    /// https://leetcode.com/problems/type-of-triangle-ii
    /// </summary>
    public static string TriangleType(int[] A)
    {
        A = A.OrderBy(x => x).ToArray();
        if (A[0] + A[1] <= A[2])
            return "none";
        if (A[0] == A[1] && A[1] == A[2])
            return "equilateral";
        if (A[0] == A[1] || A[1] == A[2])
            return "isosceles";
        return "scalene";
    }
}
