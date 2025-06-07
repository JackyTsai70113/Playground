namespace playground.LeetCode._1000_1999;

public class _1298_MaxCandies
{
    public static int MaxCandies(
        int[] status,
        int[] candies,
        int[][] keys,
        int[][] containedBoxes,
        int[] initialBoxes)
    {
        int n = status.Length;
        int res = 0;

        var validBoxes = new Queue<int>();
        var ownedBoxes = new bool[n];
        var ownedKeys = new bool[n];
        foreach (var initialBox in initialBoxes)
        {
            ownedBoxes[initialBox] = true;
            if (status[initialBox] == 1)
            {
                validBoxes.Enqueue(initialBox);
            }
        }

        while (validBoxes.Count > 0)
        {
            int box = validBoxes.Dequeue();

            res += candies[box];

            foreach (var key in keys[box])
            {
                if (!ownedKeys[key])
                {
                    ownedKeys[key] = true;
                    if (ownedBoxes[key] && status[key] == 0)
                    {
                        status[key] = 1;
                        validBoxes.Enqueue(key);
                    }
                }
            }

            foreach (int containedBox in containedBoxes[box])
            {
                if (!ownedBoxes[containedBox])
                {
                    ownedBoxes[containedBox] = true;
                    if (status[containedBox] == 1 || ownedKeys[containedBox])
                    {
                        validBoxes.Enqueue(containedBox);
                    }
                }
            }
        }
        return res;
    }
}
