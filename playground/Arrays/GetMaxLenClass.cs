namespace playground.Arrays;

public class GetMaxLenClass
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-length-of-subarray-with-positive-product
    /// </summary>
    public static int GetMaxLen(int[] nums)
    {
        int post = 0, neg = 0, res = 0;
        foreach (var num in nums)
        {
            if (num > 0)
            {
                post++;
                neg = neg > 0 ? neg + 1 : 0;
            }
            else if (num < 0)
            {
                var newPost = neg > 0 ? neg + 1 : 0;
                neg = post + 1;
                post = newPost;
            }
            else
            {
                post = neg = 0;
            }
            res = Math.Max(res, post);
        }
        return res;
    }
}
