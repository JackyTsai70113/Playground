namespace playground;

public class MaximumSwap0670
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-swap
    /// </summary>
    public static int MaximumSwap(int num)
    {
        var res = num.ToString().ToCharArray();
        var indexes = new int[10];
        for (int i = 0; i < res.Length; i++)
        {
            indexes[res[i] - '0'] = i;
        }
        bool isBreak = false;
        for (int i = 0; i < res.Length; i++)
        {
            for (int j = 9; j > res[i] - '0' && !isBreak; j--)
            {
                if (indexes[j] > i)
                {
                    (res[indexes[j]], res[i]) = (res[i], res[indexes[j]]);
                    isBreak = true;
                    break;
                }
            }
        }
        return int.Parse(new string(res));
    }
}
