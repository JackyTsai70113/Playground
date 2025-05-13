namespace playground.LeetCode._3000_3999;

public class _3304_KthCharacter
{
    public static char KthCharacter(int k)
    {
        if (k == 1) return 'a';
        k--;
        int a = (int)Math.Log(k, 2);
        return (char)(KthCharacter(k - (1 << a) + 1) + 1);
    }
}
