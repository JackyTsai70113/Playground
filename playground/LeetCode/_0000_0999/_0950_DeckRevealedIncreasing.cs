namespace playground.LeetCode._0000_0999;

public class _0950_DeckRevealedIncreasing
{
    /// <summary>
    /// https://leetcode.com/problems/reveal-cards-in-increasing-order
    /// </summary>
    public static int[] DeckRevealedIncreasing(int[] deck)
    {
        var q = new Queue<int>();
        Array.Sort(deck);
        for (int i = 0; i < deck.Length; i++)
        {
            q.Enqueue(i);
        }
        var res = new int[deck.Length];
        int j = 0;
        while (q.Count > 0)
        {
            res[q.Dequeue()] = deck[j++];
            if (q.Count > 1)
            {
                q.Enqueue(q.Dequeue());
            }
        }
        return res;
    }
}
