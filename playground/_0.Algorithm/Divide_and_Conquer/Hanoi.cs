namespace playground;

public class Hanoi
{
    /// <summary>
    /// A B C
    /// 將 河內塔從 A 移動至 C 
    /// </summary>
    /// <param name="n">河內塔層數</param>
    /// <returns>次數</returns>
    public static int HanoiSteps(int n)
    {
        return HanoiSteps(n, 'A', 'C');
    }

    static int HanoiSteps(int n, char from, char to)
    {
        if (n == 1) return 1;
        char other = (char)('A' + 'B' + 'C' - from - to);
        int res = HanoiSteps(n - 1, from, other);
        res += HanoiSteps(1, from, to);
        res += HanoiSteps(n - 1, other, to);
        return res;
    }
}
