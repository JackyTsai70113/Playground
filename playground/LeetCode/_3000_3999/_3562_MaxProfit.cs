namespace playground.LeetCode._3000_3999;

public class _3562_MaxProfit
{
    private List<int>[] adj;
    private int[] present;
    private int[] future;
    private int budget;

    private (int[] NoBuy, int[] Buy)[,] memo_results;

    public int MaxProfit(int n, int[] presentPrices, int[] futurePrices, int[][] hierarchy, int budget)
    {
        present = presentPrices;
        future = futurePrices;
        this.budget = budget;

        adj = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            adj[i] = new List<int>();
        }

        for (int i = 0; i < n - 1; i++)
        {
            adj[hierarchy[i][0] - 1].Add(hierarchy[i][1] - 1);
        }

        memo_results = new (int[] NoBuy, int[] Buy)[n, 2];

        (int[] dp_ceo_no_buy, int[] dp_ceo_buy) = DFS(0, false);

        int max_total_profit = 0;

        for (int c = 0; c <= this.budget; c++)
        {
            if (dp_ceo_no_buy[c] != int.MinValue)
            {
                max_total_profit = Math.Max(max_total_profit, dp_ceo_no_buy[c]);
            }
            if (dp_ceo_buy[c] != int.MinValue)
            {
                max_total_profit = Math.Max(max_total_profit, dp_ceo_buy[c]);
            }
        }

        return max_total_profit;
    }

    private (int[] NoBuy, int[] Buy) DFS(int u_idx, bool parent_bought_status)
    {
        int parent_status_int = parent_bought_status ? 1 : 0;
        if (memo_results[u_idx, parent_status_int].NoBuy != null)
        {
            return memo_results[u_idx, parent_status_int];
        }

        int[] dp_no_buy_u = new int[budget + 1];
        Array.Fill(dp_no_buy_u, int.MinValue);
        dp_no_buy_u[0] = 0;

        int[] dp_buy_u = new int[budget + 1];
        Array.Fill(dp_buy_u, int.MinValue);

        int cost_u_self;
        int profit_u_self;

        if (parent_bought_status)
        {
            cost_u_self = present[u_idx] / 2;
        }
        else
        {
            cost_u_self = present[u_idx];
        }
        profit_u_self = future[u_idx] - cost_u_self;

        if (cost_u_self <= budget)
        {
            dp_buy_u[cost_u_self] = Math.Max(dp_buy_u[cost_u_self], profit_u_self);
        }

        foreach (int v_idx in adj[u_idx])
        {
            (int[] dp_v_no_buy_if_u_not_bought, int[] dp_v_buy_if_u_not_bought) = DFS(v_idx, false);

            int[] v_options_if_u_not_bought_combined = new int[budget + 1];
            Array.Fill(v_options_if_u_not_bought_combined, int.MinValue);
            for (int k = 0; k <= budget; k++)
            {
                v_options_if_u_not_bought_combined[k] = Math.Max(dp_v_no_buy_if_u_not_bought[k], dp_v_buy_if_u_not_bought[k]);
            }

            (int[] dp_v_no_buy_if_u_bought, int[] dp_v_buy_if_u_bought) = DFS(v_idx, true);

            int[] v_options_if_u_bought_combined = new int[budget + 1];
            Array.Fill(v_options_if_u_bought_combined, int.MinValue);
            for (int k = 0; k <= budget; k++)
            {
                v_options_if_u_bought_combined[k] = Math.Max(dp_v_no_buy_if_u_bought[k], dp_v_buy_if_u_bought[k]);
            }

            int[] next_dp_no_buy_u = new int[budget + 1]; Array.Fill(next_dp_no_buy_u, int.MinValue);
            int[] next_dp_buy_u = new int[budget + 1]; Array.Fill(next_dp_buy_u, int.MinValue);

            for (int c_u = 0; c_u <= budget; c_u++)
            {
                if (dp_no_buy_u[c_u] == int.MinValue) continue;
                for (int c_v = 0; c_v <= budget - c_u; c_v++)
                {
                    if (v_options_if_u_not_bought_combined[c_v] == int.MinValue) continue;
                    int new_cost = c_u + c_v;
                    int new_profit = dp_no_buy_u[c_u] + v_options_if_u_not_bought_combined[c_v];
                    next_dp_no_buy_u[new_cost] = Math.Max(next_dp_no_buy_u[new_cost], new_profit);
                }
            }

            for (int c_u = 0; c_u <= budget; c_u++)
            {
                if (dp_buy_u[c_u] == int.MinValue) continue;
                for (int c_v = 0; c_v <= budget - c_u; c_v++)
                {
                    if (v_options_if_u_bought_combined[c_v] == int.MinValue) continue;
                    int new_cost = c_u + c_v;
                    int new_profit = dp_buy_u[c_u] + v_options_if_u_bought_combined[c_v];
                    next_dp_buy_u[new_cost] = Math.Max(next_dp_buy_u[new_cost], new_profit);
                }
            }

            dp_no_buy_u = next_dp_no_buy_u;
            dp_buy_u = next_dp_buy_u;
        }

        return memo_results[u_idx, parent_status_int] = (dp_no_buy_u, dp_buy_u);
    }
}