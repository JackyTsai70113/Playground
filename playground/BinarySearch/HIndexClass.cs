namespace playground.BinarySearch;

public class HIndexClass
{
    /// <remarks>https://leetcode.com/problems/h-index-ii</remarks>
    public static int HIndex(int[] ci) {
        int n = ci.Length, l = 0, r = n-1;
        while(l<r){
            int m = l + (r-l+1)/2;
            if(ci[m] >= n-m){
                r = m - 1;
            } else {
                l = m;
            }
        }
        if(n-1-l==0){
            return 0;
        } else {
            return Math.Min(ci[l + 1], n - 1 - l);
        }
    }
}
