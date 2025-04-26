namespace playground._3500_3599;

public class _3518_SmallestPalindrome
{
    public static string SmallestPalindrome(string s, int k)
    {
        // Step 1: Count character frequencies
        var freq = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (!freq.ContainsKey(c))
                freq[c] = 0;
            freq[c]++;
        }

        // Step 2: Check if a palindromic permutation is possible
        char middleChar = s.Length % 2 == 0 ? '\0' : s[s.Length / 2];

        // Step 3: Prepare the first half of the palindrome
        var half = new List<char>();
        foreach (var kvp in freq)
        {
            for (int i = 0; i < kvp.Value / 2; i++)
                half.Add(kvp.Key);
        }

        // Step 4: Generate all unique permutations of the first half
        var permutations = new List<string>();
        GeneratePermutations(half.ToArray(), 0, permutations);

        // Step 5: Sort permutations lexicographically
        permutations.Sort();

        // Step 6: Find the k-th permutation
        if (k > permutations.Count)
            return ""; // k exceeds the number of permutations

        string firstHalf = permutations[k - 1];

        // Step 7: Construct the full palindrome
        string secondHalf = new string(firstHalf.Reverse().ToArray());
        return middleChar == '\0' ? firstHalf + secondHalf : firstHalf + middleChar + secondHalf;
    }

    private static void GeneratePermutations(char[] arr, int index, List<string> result)
    {
        if (index == arr.Length)
        {
            result.Add(new string(arr));
            return;
        }

        var seen = new HashSet<char>();
        for (int i = index; i < arr.Length; i++)
        {
            if (seen.Contains(arr[i]))
                continue;
            seen.Add(arr[i]);

            Swap(arr, index, i);
            GeneratePermutations(arr, index + 1, result);
            Swap(arr, index, i); // Backtrack
        }
    }

    private static void Swap(char[] arr, int i, int j)
    {
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
