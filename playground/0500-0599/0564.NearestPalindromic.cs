namespace playground;

public class NearestPalindromic0564
{
    public static string NearestPalindromic(string n)
    {
        var possibilities = new List<long>();
        int halfLen = n.Length % 2 == 0 ?
            n.Length / 2 - 1 : n.Length / 2;
        long firstHalf = long.Parse(n[..(halfLen + 1)]);
        possibilities.Add((long)Math.Pow(10, n.Length - 1) - 1);
        possibilities.Add(HalfToPalindrome(firstHalf - 1, n.Length % 2 == 0));
        possibilities.Add(HalfToPalindrome(firstHalf, n.Length % 2 == 0));
        possibilities.Add(HalfToPalindrome(firstHalf + 1, n.Length % 2 == 0));
        possibilities.Add((long)Math.Pow(10, n.Length) + 1);

        long res = long.MaxValue;
        long num = long.Parse(n);
        foreach (var p in possibilities)
        {
            if (p == num)
                continue;
            if (Math.Abs(num - p) < Math.Abs(num - res))
                res = p;
        }
        return res.ToString();
    }

    public static long HalfToPalindrome(long firstHalf, bool even)
    {
        long res = firstHalf;
        if (even)
        {
            res = res * 10 + firstHalf % 10;
        }
        firstHalf /= 10;
        while (firstHalf > 0)
        {
            res = res * 10 + firstHalf % 10;
            firstHalf /= 10;
        }
        return res;
    }
}
