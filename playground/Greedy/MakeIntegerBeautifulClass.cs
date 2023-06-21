namespace playground.Greedy;

public class MakeIntegerBeautifulClass
{
    public static long MakeIntegerBeautiful(long n, int target)
    {
        var sum = n.ToString().Select(x => int.Parse(x.ToString())).Sum();
        long res = 0, r = 0;
        while (sum > target)
        {
            long num = (long)Math.Pow(10, r + 1);
            res += num - n % num;
            n = n + num - n % num;
            r++;
            sum = n.ToString().Select(x => int.Parse(x.ToString())).Sum();
        }
        return res;
    }
}
