namespace playground.LeetCode._3000_3999;

public class _3602_ConcatHex36
{
    public static string ConcatHex36(int n)
    {
        int n2 = n * n;
        int n3 = n * n * n;
        string hex = n2.ToString("X");
        string hex36 = ToBase36(n3);
        return hex + hex36;
    }

    private static string ToBase36(int value)
    {
        const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var result = new System.Text.StringBuilder();
        int v = value;
        while (v > 0)
        {
            result.Insert(0, chars[v % 36]);
            v /= 36;
        }
        return result.ToString();
    }
}
