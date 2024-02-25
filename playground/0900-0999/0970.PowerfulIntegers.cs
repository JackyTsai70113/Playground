namespace playground;

public class PowerfulIntegers0970
{
    /// <summary>
    /// https://leetcode.com/problems/powerful-integers
    /// </summary>
    public static IList<int> PowerfulIntegers(int x, int y, int bound)
    {
        HashSet<int> s1 = new(), s2 = new(), res = new();
        if (x == 1)
        {
            s1.Add(1);
        }
        else
        {
            int a = 1;
            while (a <= bound)
            {
                s1.Add(a);
                a *= x;
            }
        }

        if (y == 1)
        {
            s2.Add(1);
        }
        else
        {
            int a = 1;
            while (a <= bound)
            {
                s2.Add(a);
                a *= y;
            }
        }

        foreach (var num1 in s1)
        {
            foreach (var num2 in s2)
            {
                if (num1 + num2 <= bound)
                    res.Add(num1 + num2);
            }
        }
        return res.ToList();
    }
}
