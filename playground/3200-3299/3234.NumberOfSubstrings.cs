namespace playground;

public class NumberOfSubstrings3234
{
    public int NumberOfSubstrings(string s)
    {
        int n = s.Length;
        List<int> zeros = new();
        for (int i = 0; i < n; i++)
        {
            if (s[i] == '0')
                zeros.Add(i);
        }
        if (zeros.Count == 0) return n * (n + 1) / 2;
        zeros.Add(n);
        int zeroIdxStart = 0, count, res = 0;
        for (int l = 0; l < n; l++)
        {
            while (zeros[zeroIdxStart] < l) zeroIdxStart++;
            count = 0;
            int last = l;
            for (int zeroIdx = zeroIdxStart; zeroIdx < zeros.Count && zeroIdx < zeroIdxStart + 201; zeroIdx++)
            {
                int minIndex = Math.Max(l + count + count * count - 1, last);
                res += Math.Max(0, zeros[zeroIdx] - minIndex);
                count++;
                last = zeros[zeroIdx];
            }
        }
        return res;
    }
}
