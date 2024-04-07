namespace playground.Stacks;

public class HonaiClass
{
    /// <summary>
    /// A B C
    /// 將 河內塔從 A 移動至 C 
    /// </summary>
    /// <param name="n">河內塔層數</param>
    /// <returns>次數</returns>
    public static int Honai(int n)
    {
        int res = Honai(n, 'A', 'C');
        return res;
    }

    static int Honai(int n, char from, char to)
    {
        if (n == 1)
        {
            return 1;
        }
        var other = (char)('A' + 'B' + 'C' - from - to);
        var res = 0;
        res += Honai(n - 1, from, other);
        res += Honai(1, from, to);
        res += Honai(n - 1, other, to);
        return res;
    }
}
