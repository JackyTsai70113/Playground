namespace playground;

public class HasTrailingZeros2980
{
    /// <summary>
    /// https://leetcode.com/problems/check-if-bitwise-or-has-trailing-zeros
    /// </summary>
    public static bool HasTrailingZeros(int[] nums) {
        for(int i = 0; i < nums.Length; ++i){
            for(int j = i+1; j < nums.Length; ++j){
                if((nums[i] | nums[j])%2==0)
                    return true;
            }
        }
        return false;
    }
}
