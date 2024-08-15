namespace playground;

public class LemonadeChange860
{
    public static bool LemonadeChange(int[] bills)
    {
        int five = 0, ten = 0;
        foreach (var b in bills)
        {
            if (b == 5)
            {
                five++;
            }
            else if (b == 10)
            {
                if (--five < 0)
                    return false;
                ten++;
            }
            else
            {
                if (five >= 1 && ten >= 1)
                {
                    five--;
                    ten--;
                }
                else if (five >= 3)
                {
                    five -= 3;
                }
                else
                {
                    return false;
                }
            }
        }
        return true;
    }
}