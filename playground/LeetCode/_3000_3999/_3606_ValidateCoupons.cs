namespace playground.LeetCode._3000_3999;

public class _3606_ValidateCoupons
{
    public static IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive)
    {
        var coupons = new List<(string code, string line)>();
        Dictionary<string, int> businessLineOrder = new()
        {
            {"electronics", 0},
            {"grocery", 1},
            {"pharmacy", 2},
            {"restaurant", 3}
        };
        for (int i = 0; i < code.Length; i++)
        {
            bool valid = true;
            if (string.IsNullOrEmpty(code[i]))
            {
                valid = false;
            }
            if (!valid) continue;
            foreach (var c in code[i])
            {
                if (!char.IsLetterOrDigit(c) && c != '_')
                {
                    valid = false;
                    break;
                }
            }
            if (!valid) continue;

            if (!businessLineOrder.ContainsKey(businessLine[i])) continue;
            if (!isActive[i]) continue;
            coupons.Add((code[i], businessLine[i]));
        }

        return coupons
            .OrderBy(x => businessLineOrder[x.line])
            .ThenBy(c => c.code, StringComparer.Ordinal)
            .Select(x => x.code)
            .ToList();
    }
}
