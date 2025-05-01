namespace playground._3400_3499;

public class _3461_HasSameDigits
{
    public static bool HasSameDigits(string s)
    {
        var arr = new List<int>();
        for (int i = 0; i < s.Length - 1; i++)
        {
            arr.Add((s[i] - '0' + s[i + 1] - '0') % 10);
        }
        while (arr.Count > 2)
        {
            var arr2 = new List<int>();
            for (int i = 0; i < arr.Count - 1; i++)
            {
                arr2.Add((arr[i] + arr[i + 1]) % 10);
            }
            arr = arr2;
        }
        return arr[0] == arr[1];
    }
}
