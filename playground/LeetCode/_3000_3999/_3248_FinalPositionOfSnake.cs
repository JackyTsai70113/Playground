namespace playground;

public class _3248_FinalPositionOfSnake
{
    public static int FinalPositionOfSnake(int n, IList<string> commands)
    {
        int i = 0, j = 0;
        foreach (var s in commands)
        {
            if (s == "UP")
            {
                i--;
            }
            else if (s == "RIGHT")
            {
                j++;
            }
            else if (s == "DOWN")
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        return i * n + j;
    }
}
