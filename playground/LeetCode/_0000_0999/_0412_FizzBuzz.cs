namespace playground.LeetCode._0000_0999;

public class _0412_FizzBuzz
{
    /// <summary>
    /// https://leetcode.com/problems/fizz-buzz
    /// </summary>
    public static IList<string> FizzBuzz(int n)
    {
        var res = new string[n];
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                if (i % 5 == 0)
                {
                    res[i - 1] = "FizzBuzz";
                }
                else
                {
                    res[i - 1] = "Fizz";
                }
            }
            else if (i % 5 == 0)
            {
                res[i - 1] = "Buzz";
            }
            else
            {
                res[i - 1] = i.ToString();
            }
        }
        return res;
    }
}
