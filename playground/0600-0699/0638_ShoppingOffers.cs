namespace playground._0600_0699;

public class _0638_ShoppingOffers
{
    Dictionary<string, int> memo = new();
    public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs)
    {
        var key = string.Join(",", needs);
        if (memo.ContainsKey(key))
            return memo[key];
        int n = price.Count;
        int res = Enumerable.Range(0, n).Sum(i => price[i] * needs[i]);
        for (int i = 0; i < special.Count; i++)
        {
            var clonedNeeds = new List<int>();
            for (int j = 0; j < n; j++)
            {
                int diff = needs[j] - special[i][j];
                if (diff < 0)
                {
                    break;
                }
                clonedNeeds.Add(diff);
            }
            if (clonedNeeds.Count == n)
            {
                res = Math.Min(res, special[i][^1] + ShoppingOffers(price, special, clonedNeeds));
            }
        }
        return memo[key] = res;
    }
}
