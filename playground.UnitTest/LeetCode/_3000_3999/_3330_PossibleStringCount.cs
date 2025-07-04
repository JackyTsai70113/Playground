namespace playground.UnitTest.LeetCode._3000_3999;

public class _3330_PossibleStringCount
{
    public static int PossibleStringCount(string word)
    {
        int count = 0;
        int l = 0;
        for (int r = 0; r <= word.Length; r++)
        {
            if (r == word.Length || word[r] != word[l])
            {
                count += r - l - 1;
                l = r;
            }
        }
        return count + 1;
    }
}
