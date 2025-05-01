using System.Text;

namespace playground.LeetCode._0000_0999;

public class _0726_CountOfAtoms
{
    private int index = 0;
    public string CountOfAtoms(string A)
    {
        var dict = ParseFormula(A);
        StringBuilder sb = new();
        foreach (var key in dict.Keys.OrderBy(x => x))
        {
            if (dict[key] == 1)
                sb.Append(key);
            else
                sb.Append(key + dict[key].ToString());
        }
        return sb.ToString();
    }

    private Dictionary<string, int> ParseFormula(string s)
    {
        var res = new Dictionary<string, int>();
        string atom = "", count = "";
        while (index < s.Length)
        {
            if (char.IsUpper(s[index]))
            {
                AddAtom(res, atom, count);
                count = "";
                atom = s[index].ToString();
                index++;
            }
            else if (char.IsLower(s[index]))
            {
                atom += s[index];
                index++;
            }
            else if (char.IsDigit(s[index]))
            {
                count += s[index];
                index++;
            }
            else if (s[index] == '(')
            {
                index++;
                var nested = ParseFormula(s);
                foreach (var key in nested.Keys)
                {
                    res[key] = res.GetValueOrDefault(key, 0) + nested[key];
                }
            }
            else if (s[index] == ')')
            {
                AddAtom(res, atom, count);
                atom = "";
                index++;
                string multiplier = "";
                while (index < s.Length && char.IsDigit(s[index]))
                {
                    multiplier += s[index];
                    index++;
                }
                if (multiplier != "")
                {
                    int mul = int.Parse(multiplier);
                    foreach (var key in res.Keys)
                    {
                        res[key] *= mul;
                    }
                }
                return res;
            }
        }
        AddAtom(res, atom, count);
        return res;
    }

    private void AddAtom(Dictionary<string, int> dict, string atom, string count)
    {
        if (atom != "")
        {
            var curCount = count == "" ? 1 : int.Parse(count);
            dict[atom] = dict.GetValueOrDefault(atom, 0) + curCount;
        }
    }
}
