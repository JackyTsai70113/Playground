namespace playground.LeetCode._0000_0999;

public class _0838_PushDominoes
{
    public static string PushDominoes(string s)
    {
        var list = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '.')
            {
                list.Add(i);
            }
        }

        var res = s.ToCharArray();
        if (s[list[0]] == 'L')
        {
            for (int i = 0; i < list[0]; i++)
                res[i] = 'L';
        }
        if (s[list[^1]] == 'R')
        {
            for (int i = list[^1] + 1; i < s.Length; i++)
                res[i] = 'R';
        }
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (s[list[i]] == 'R' && s[list[i + 1]] == 'L')
            {
                int mid = (list[i] + list[i + 1] + 1) / 2;
                for (int j = list[i] + 1; j < mid; j++)
                    res[j] = 'R';
                if ((list[i + 1] - list[i]) % 2 == 0)
                    mid++;
                for (int j = mid; j < list[i + 1]; j++)
                    res[j] = 'L';
            }
            else if (s[list[i]] == s[list[i + 1]])
            {
                for (int j = list[i] + 1; j < list[i + 1]; j++)
                    res[j] = s[list[i]];
            }
        }
        return new string(res);
    }
}
