namespace playground;

public class NumberOfSubarrays3113
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-number-of-subarrays-where-boundary-elements-are-maximum
    /// </summary>
    public static long NumberOfSubarrays(int[] nums)
    {
        int n = nums.Length;
        long res = 0;
        Stack<int> st = new();
        var d = new Dictionary<int, int>();
        for (int i = n - 1; i >= 0; i--)
        {
            while (st.Count > 0 && nums[st.Peek()] < nums[i])
            {
                d[nums[st.Peek()]]--;
                st.Pop();
            }
            st.Push(i);
            d[nums[i]] = d.ContainsKey(nums[i]) ? d[nums[i]] + 1 : 1;
            res += d[nums[i]];
        }
        return res;
    }
}
