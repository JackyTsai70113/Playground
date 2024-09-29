namespace playground;

public class TakeCharacters2516
{
    public static int TakeCharacters(string s, int k)
    {
        bool IsValid(int[] cnt)
        {
            for (int i = 0; i < cnt.Length; i++)
            {
                if (cnt[i] < k)
                    return false;
            }
            return true;
        }
        int[] cnt = new int[3];
        int max = 0;
        foreach (var c in s)
        {
            cnt[c - 'a']++;
        }
        if (!IsValid(cnt))
        {
            return -1;
        }

        for (int l = 0, r = 0; r < s.Length; r++)
        {
            cnt[s[r] - 'a']--;
            while (l <= r && !IsValid(cnt))
            {
                cnt[s[l++] - 'a']++;
            }
            max = Math.Max(max, r - l + 1);
        }
        return s.Length - max;
    }
}
