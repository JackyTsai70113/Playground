namespace playground.BinarySearch
{
    public class MinimizeMaxClass
    {
        /// <remarks>https://leetcode.com/problems/minimize-the-maximum-difference-of-pairs</remarks>
        public static int MinimizeMax(int[] nums, int p)
        {
            Array.Sort(nums);
            int n = nums.Length;
            int l = 0, r = nums[n - 1] - nums[0];
            while (l < r)
            {
                int m = l + (r - l) / 2;

                int ct = 0;
                for (int i = 0; i < n - 1 && ct <= p; ++i)
                {
                    if (nums[i + 1] - nums[i] <= m)
                    {
                        ct++;
                        i++;
                    }
                }
                if (ct >= p)
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            return l;
        }
    }
}