namespace playground;

public class _1255_MaxScoreWords
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-score-words-formed-by-letters
    /// </summary>
    public static int MaxScoreWords(string[] words, char[] letters, int[] score)
    {
        var res = new int[1];
        var chs = new int[256];
        foreach (var c in letters)
            chs[c]++;
        Bt(words, chs, score, 0, 0, res);
        return res[0];
    }

    static void Bt(string[] words, int[] chs, int[] score, int i, int curScore, int[] res)
    {
        if (i == words.Length)
        {
            res[0] = Math.Max(res[0], curScore);
            return;
        }
        var next = chs.ToArray();
        var nextScore = curScore;
        var valid = true;
        foreach (var c in words[i])
        {
            if (--next[c] < 0)
            {
                valid = false;
                break;
            }
            nextScore += score[c - 'a'];
        }
        if (valid)
        {
            Bt(words, next, score, i + 1, nextScore, res);
        }
        Bt(words, chs, score, i + 1, curScore, res);
    }
}
