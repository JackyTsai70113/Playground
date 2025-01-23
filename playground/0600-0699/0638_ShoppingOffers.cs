namespace playground._0600_0699;

public class _0638_ShoppingOffers
{
    public static int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> needs)
    {
        int n = price.Count;
        var pq = new PriorityQueue<int, double>();
        var ratio = new double[special.Count];
        for (int i = 0; i < special.Count; i++)
        {
            int specialPrice = special[i][^1];
            int originalPrice = 0;
            bool need = true;
            for (int j = 0; j < n; j++)
            {
                if (special[i][j] > needs[j])
                {
                    need = false;
                    break;
                }
                originalPrice += special[i][j] * price[j];
            }
            if (need)
            {
                pq.Enqueue(i, (double)specialPrice / originalPrice);
            }
        }
        int res = 0;
        while (pq.Count > 0)
        {
            var index = pq.Dequeue();
            int count = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (special[index][i] != 0)
                {
                    count = Math.Min(count, needs[i] / special[index][i]);
                }
            }
            if (count > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    needs[i] -= count * special[index][i];
                }
                res += count * special[index][^1];
            }
        }
        for (int i = 0; i < needs.Count; i++)
        {
            res += price[i] * needs[i];
        }
        return res;
    }
}
