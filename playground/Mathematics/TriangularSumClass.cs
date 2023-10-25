namespace playground.Mathematics;

public class TriangularSumClass
{
    /// <summary>
    /// https://leetcode.com/problems/find-triangular-sum-of-an-array
    /// </summary>
    public static int TriangularSum(int[] nums)
    {
        for (int i = 1; i < nums.Length; ++i)
        {
            for (int j = 0; j < nums.Length - 1; ++j)
            {
                nums[j] = (nums[j] + nums[j + 1]) % 10;
            }
        }
        return nums[0];
    }

    /// <summary>
    /// O(n), O(1), 模反元素(Modular multiplicative inverse)
    /// </summary>
    public static int TriangularSum2(int[] nums)
    {
        int m = nums.Length - 1, res = 0;
        int coefficientWithout2and5 = 1, exp2 = 0, exp5 = 0;
        var inv10 = new int[] { 0, 1, 0, 7, 0, 0, 0, 3, 0, 9 };
        var pow2mod10 = new int[] { 6, 2, 4, 8 };
        for (int k = 0; k <= m; ++k)
        {
            if (k > 0)
            {
                // coefficientWithout2and5 *= m - k
                int mul = m - k + 1;
                while (mul % 2 == 0)
                {
                    mul /= 2;
                    exp2++;
                }
                while (mul % 5 == 0)
                {
                    mul /= 5;
                    exp5++;
                }
                coefficientWithout2and5 = coefficientWithout2and5 * mul % 10;

                // coefficientWithout2and5 / k
                int div = k;
                while (div % 2 == 0)
                {
                    div /= 2;
                    exp2--;
                }
                while (div % 5 == 0)
                {
                    div /= 5;
                    exp5--;
                }
                coefficientWithout2and5 = coefficientWithout2and5 * inv10[div % 10] % 10;
            }

            if (exp2 == 0 || exp5 == 0)
            {
                int coefficient =
                    exp2 > 0 ? coefficientWithout2and5 * pow2mod10[exp2 % 4] :
                    exp5 > 0 ? coefficientWithout2and5 * 5 : coefficientWithout2and5;
                res = (res + coefficient * nums[k]) % 10;
            }
        }
        return res;
    }
}
