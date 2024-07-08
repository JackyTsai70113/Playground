namespace playground;

public class PassThePillow2582
{
    /// <summary>
    /// https://leetcode.com/problems/pass-the-pillow
    /// </summary>
    public static int PassThePillow(int n, int time) {
        int mod = time % (2 * n - 2);
        if(mod < n)
            return 1 + mod;
        else
            return n - (mod - n + 1);
    }
}
