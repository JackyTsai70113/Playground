using System;

namespace playground.LeetCode._3000_3999;

public class _3265_CountPairs
{
    public static int CountPairs(int[] nums)
    {
        int res = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                var str1 = nums[i].ToString();
                var str2 = nums[j].ToString();
                if (str1.Length < str2.Length)
                {
                    str1 = new string('0', str2.Length - str1.Length) + str1;
                }
                else if (str1.Length > str2.Length)
                {
                    str2 = new string('0', str1.Length - str2.Length) + str2;
                }
                int count = 0;
                for (int k = 0; k < str1.Length && count <= 2; k++)
                {
                    if (str1[k] != str2[k])
                        count++;
                }
                if (count <= 2 && string.Concat(str1.OrderBy(c => c)) == string.Concat(str2.OrderBy(c => c)))
                    res++;
            }
        }
        return res;
    }
}
