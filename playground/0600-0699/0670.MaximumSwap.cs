namespace playground;

public class MaximumSwap0670
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-swap
    /// </summary>
    public static int MaximumSwap(int num)
    {
        var res = num.ToString().ToCharArray();
        for (int i = 0; i < res.Length; i++)
        {
            int r = i;
            for (int j = i + 1; j < res.Length; j++)
            {
                if (res[r] <= res[j])
                {
                    r = j;
                }
            }
            if (i != r && res[i] != res[r])
            {
                (res[i], res[r]) = (res[r], res[i]);
                break;
            }
        }
        return int.Parse(new string(res));
    }
}
