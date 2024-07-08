namespace playground;

public class NumberOfAlternatingGroups3206
{
    /// <summary>
    /// https://leetcode.com/problems/alternating-groups-i
    /// </summary>
    public static int NumberOfAlternatingGroups(int[] A) {
        var res = 0;
        for(int i = 1; i < A.Length - 1; i++){
            if(A[i-1] != A[i] && A[i] != A[i+1])
                res++;
        }
        if(A[^1] != A[0] && A[0] != A[1])
            res++;
        if(A[^2] != A[^1] && A[^1] != A[0])
            res++;
        return res;
    }
}
