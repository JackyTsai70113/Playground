namespace playground;

public class MinChanges3226
{
    public int MinChanges(int n, int k)
    {
        int res = 0;
        for (int i = 0; i < 32; i++)
        {
            if ((n >> i & 1) == 1 && (k >> i & 1) == 0)
                res++;
            else if ((n >> i & 1) == 0 && (k >> i & 1) == 1)
                return -1;
        }
        return res;
    }
}
