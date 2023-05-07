namespace playground.Greedy;

public class PredictPartyVictoryClass
{
    public static string PredictPartyVictory(string senate)
    {
        int n = senate.Length;
        int r = 0, d = 0;
        bool[] alive = Enumerable.Repeat(true, n).ToArray();
        foreach (var se in senate)
        {
            if (se == 'R') r++;
            else d++;
        }
        while (true)
        {
            for (int i = 0; i < n; ++i)
            {
                if (alive[i] && senate[i] == 'R')
                {
                    if (d == 0) return "Radiant";
                    for (int j = i + 1; j < i + 1 + n; ++j)
                    {
                        if (alive[j % n] && senate[j % n] == 'D')
                        {
                            alive[j % n] = false;
                            d--;
                            break;
                        }
                    }
                }
                else if (alive[i] && senate[i] == 'D')
                {
                    if (r == 0) return "Dire";
                    for (int j = i + 1; j < i + 1 + n; ++j)
                    {
                        if (alive[j % n] && senate[j % n] == 'R')
                        {
                            alive[j % n] = false;
                            r--;
                            break;
                        }
                    }
                }
            }
        }
    }

    public static string PredictPartyVictory2(string senate)
    {
        int n = senate.Length;
        Queue<int> qr = new(), qd = new();
        for (int i = 0; i < n; i++)
        {
            if (senate[i] == 'R') qr.Enqueue(i);
            else qd.Enqueue(i);
        }
        while (qr.Count > 0 && qd.Count > 0)
        {
            int r = qr.Dequeue(), d = qd.Dequeue();
            if (r < d) qr.Enqueue(n + r);
            else qd.Enqueue(n + d);
        }
        return qr.Count == 0 ? "Dire" : "Radiant";
    }
}
