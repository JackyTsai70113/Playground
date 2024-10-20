namespace playground._0.Algorithm;

public class LongestPalindromicSubstring
{
    // Manacher's Algorithm to get max palindrome length
    // s:   abaaba
    // hashtagS:   #  a  #  b  #  a  #  a  #  b  #  a  # 
    // index:      0  1  2  3  4  5  6  7  8  9 10 11 12
    // lps_length: 1  2  1  4  1  2  7  2  1  4  1  2  1
    public static int[] Manacher(string s)
    {
        var hashtagS = Hashtag(s);
        int n = hashtagS.Length;
        int[] p = new int[n];  // Store radius of palindromes
        int l = 0, r = 0;

        for (int i = 0; i < n; i++)
        {
            if (i < r)
            {
                p[i] = Math.Min(p[l + (r - i)], r - i);  // Get minimum palindrome length based on mirror position
            }
            // Expand around the center to find palindromes
            while (i - p[i] >= 0 && i + p[i] < n && hashtagS[i - p[i]] == hashtagS[i + p[i]])
            {
                p[i]++;
            }
            // Update the left and right bounds
            if (i + p[i] > r)
            {
                l = i - p[i];
                r = i + p[i];
            }
        }
        return p;
    }

    private static char[] Hashtag(string s)
    {
        char[] chs = new char[2 * s.Length + 1];
        for (int i = 0; i < 2 * s.Length + 1; i++)
        {
            if (i % 2 == 0)
                chs[i] = '#';
            else
                chs[i] = s[(i - 1) / 2];
        }
        return chs;
    }
}
