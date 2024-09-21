namespace playground;

public class LexicalOrder0386
{
    public static IList<int> LexicalOrder(int n)
    {
        var res = new int[n];
        res[0] = 1;
        for (int i = 1, num = 1; i < n; i++)
        {
            if (num * 10 <= n)
            {
                num *= 10;
            }
            else
            {
                if (num + 1 > n)
                    num /= 10;
                num++;
                while (num % 10 == 0)
                    num /= 10;
            }
            res[i] = num;
        }
        return res;
    }
}
