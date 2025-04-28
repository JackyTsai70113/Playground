namespace playground._1000_1099;

public class _1040_NumMovesStonesII
{
    public int[] NumMovesStonesII(int[] A)
    {
        // Step 1: Sort the stone positions
        Array.Sort(A);

        int n = A.Length, min = n;

        // Step 2: Calculate maximum moves
        // Two cases: remove leftmost stone or rightmost stone
        int max = Math.Max(
            A[^2] - A[0] - (n - 2), // Remove last stone first
            A[^1] - A[1] - (n - 2)  // Remove first stone first
        );

        // Step 3: Calculate minimum moves using sliding window
        // Goal: find a window with the most stones within size n
        for (int l = 0, r = 0; r < n; r++)
        {
            // Shrink window from the left if the current window size exceeds n
            while (A[r] - A[l] + 1 > n)
                l++;

            int currentCount = r - l + 1;
            // If current count is n - 1 and [l, r] is continuous,
            // it need exactly 2 moves instead of 1
            if (currentCount == n - 1 && A[r] - A[l] + 1 == currentCount)
                min = Math.Min(min, 2);
            else
                // Otherwise, it needs n - currentCount moves
                min = Math.Min(min, n - currentCount);
        }
        
        return new int[] { min, max };
    }
}
