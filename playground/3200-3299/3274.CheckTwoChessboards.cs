namespace playground;

public class CheckTwoChessboards3274
{
    public static bool CheckTwoChessboards(string c1, string c2)
    {
        return (c1[0] + c1[1]) % 2 == (c2[0] + c2[1]) % 2;
    }
}