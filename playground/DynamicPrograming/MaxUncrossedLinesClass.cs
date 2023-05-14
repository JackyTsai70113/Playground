namespace playground.DynamicPrograming;

public class MaxUncrossedLinesClass
{
    public static int MaxUncrossedLines(int[] nums1, int[] nums2)
    {
        int n1=nums1.Length, n2=nums2.Length;
        int[] dp = new int[n2+1];
        for(int i=1;i<=n1;++i){
            for(int j=1, prev =0,cur;j<=n2;++j){
                cur=dp[j];
                if(nums1[i-1] == nums2[j-1]){
                    dp[j]=1+prev;
                } else{
                    dp[j]=Math.Max(dp[j], dp[j-1]);
                }
                prev=cur;
            }
        }
        return dp[n2];
    }
}
