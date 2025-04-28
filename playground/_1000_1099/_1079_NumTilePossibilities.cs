namespace playground._1000_1099;

public class _1079_NumTilePossibilities
{
    public static int NumTilePossibilities(string tiles)
    {
        int[] counts = new int[26];
        foreach (var c in tiles) counts[c - 'A']++;
        return Dfs(counts);
    }

    static int Dfs(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < 26; i++)
        {
            if (arr[i] == 0) continue;
            sum++;
            arr[i]--;
            sum += Dfs(arr);
            arr[i]++;
        }
        return sum;
    }
}
